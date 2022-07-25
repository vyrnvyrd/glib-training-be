// <copyright file="AuthServices.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

using System;
using System.Threading.Tasks;
using Garuda.Abstract.Contracts;
using Garuda.Database.Ldap.Contracts;
using Garuda.Infrastructure.Constants;
using Garuda.Infrastructure.Contracts;
using Garuda.Infrastructure.Dtos;
using Garuda.Infrastructure.Exceptions;
using Garuda.Modules.Auth.Services.Contracts;
using Garuda.Modules.Common.Dtos.Requests;
using Garuda.Modules.Common.Dtos.Responses;
using Garuda.Modules.Common.Models.Contracts;
using Garuda.Modules.Common.Models.Datas;
using Garuda.Modules.Email.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace Garuda.Modules.Auth.Services.Repositories
{
    public class AuthServices : IAuthServices
    {
        private readonly IAuthLibraryService _authLibrary;
        private readonly IStorage _iStorage;
        private readonly ILogger _logger;
        private readonly IJwtFactory _jwt;
        private readonly IEmailSender _emailSender;

        public AuthServices(
            IStorage iStorage,
            ILogger<AuthServices> logger,
            IAuthLibraryService authLibrary,
            IJwtFactory jwt,
            IEmailSender emailSender)
        {
            _iStorage = iStorage;
            _logger = logger;
            _authLibrary = authLibrary;
            _jwt = jwt;
            _emailSender = emailSender;
        }

        public async Task<LoginResponses> Login(LoginRequests model)
        {
            try
            {
                _logger.LogInformation("User logging in.");

                _logger.LogInformation("Getting user data from database..");
                var ldapUserLocal = await _iStorage.GetRepository<IUserRepository>().GetData(model.Username);

                if (ldapUserLocal != null)
                {
                    _logger.LogInformation("Getting user data from AD..");
                    var (ldapUserResponse, domain, error) = await _authLibrary.CheckAdUser(ldapUserLocal.Username, model.Password);

                    if (ldapUserResponse != null)
                    {
                        if (ldapUserLocal.IsActive == false)
                        {
                            throw ErrorConstant.INACTIVE_USER;
                        }

                        // Handle Jwt
                        _logger.LogInformation("Creating user token..");
                        var token = await _jwt.CreateTokenAsync(ldapUserLocal.Id, "Administrator", ldapUserLocal.Username, "module");

                        return new LoginResponses()
                        {
                            RefreshToken = token.RefreshToken,
                            Token = token.Token,
                            UserId = ldapUserLocal.Id,
                        };
                    }
                    else
                    {
                        throw ErrorConstant.INACTIVE_USER;
                    }
                }
                else
                {
                    _logger.LogInformation("Getting user data from AD..");
                    var (ldapUserResponse, domain, error) = await _authLibrary.CheckAdUser(model.Username, model.Password);

                    var email = ldapUserResponse.GetAttribute("sAMAccountName").StringValue + "@" + domain;
                    if (ldapUserResponse.GetAttributeSet().ContainsKey("mail") == true)
                    {
                        email = ldapUserResponse.GetAttribute("mail").StringValue;
                    }

                    ldapUserLocal = new User()
                    {
                        Email = email,
                        Fullname = ldapUserResponse.GetAttribute("displayName").StringValue,
                        Username = ldapUserResponse.GetAttribute("sAMAccountName").StringValue,
                        IsActive = false,
                        LastLogin = DateTime.Now,
                    };

                    _logger.LogInformation("Saving registered user to database..");
                    await _iStorage.GetRepository<IUserRepository>().AddOrUpdate(ldapUserLocal);
                    await _iStorage.SaveAsync();

                    _logger.LogInformation("Sending email to administrator..");
                    await SendEmail(ldapUserLocal.Username);
                    _logger.LogInformation("Email sent.");
                    throw ErrorConstant.INACTIVE_USER;
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<MessageDto> LogOff(HttpContext httpContext)
        {
            _logger.LogInformation("Getting user session..");
            var session = await _jwt.GetSession(httpContext);
            var revoked = await _jwt.Revoke(session);
            if (revoked)
            {
                _logger.LogInformation("User logged out.");
                return new MessageDto("You've been logged out");
            }
            else
            {
                throw ErrorConstant.UNAUTHORIZED;
            }
        }

        public async Task<SessionTokenDto> GetRefreshToken(HttpContext httpContext, RefreshTokenRequests model)
        {
            SessionTokenDto sessiontoken;
            SessionDto session;

            try
            {
                if (model.Token == null && model.RefreshToken == null)
                {
                    session = await _jwt.GetSession(httpContext);
                }
                else
                {
                    session = await _jwt.ReadSessionToken(model.Token);
                }

                _logger.LogInformation("Getting user token fron database..");
                var result = await _iStorage.GetRepository<IUserSessionRepository>().GetRefreshToken(session.UserId, session.Jti, false);
                if (model.RefreshToken != null)
                {
                    if (result.RefreshToken != model.RefreshToken)
                    {
                        throw ErrorConstant.UNAUTHORIZED;
                    }
                }
                else
                {
                    if (result.RefreshToken == null)
                    {
                        throw ErrorConstant.UNAUTHORIZED;
                    }
                }

                _logger.LogInformation("Creating new user token..");
                sessiontoken = await _jwt.CreateTokenAsync(session.UserId, session.UserRole, session.FullName, "module");

                return new SessionTokenDto
                {
                    Token = sessiontoken.Token,
                    RefreshToken = sessiontoken.RefreshToken,
                    Jti = sessiontoken.Jti,
                };
            }
            catch
            {
                throw ErrorConstant.INVALID_SESSION;
            }
        }

        private async Task SendEmail(string username)
        {
            await _emailSender.SendEmailToQpbAdminAsync("Account Activation", username, true);
        }
    }
}