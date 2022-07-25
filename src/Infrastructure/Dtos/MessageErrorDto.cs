// <copyright file="MessageErrorDto.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

namespace Garuda.Infrastructure.Dtos
{
    public class MessageErrorDto
    {
        public MessageErrorDto(int status, string title, string msg)
        {
            Status = status;
            Title = title;
            Message = msg;
        }

        public int Status { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }
    }
}
