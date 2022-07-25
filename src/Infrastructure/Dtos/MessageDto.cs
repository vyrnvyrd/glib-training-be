// <copyright file="MessageDto.cs" company="CV Garuda Infinity Kreasindo">
// Copyright (c) CV Garuda Infinity Kreasindo. All rights reserved.
// </copyright>

namespace Garuda.Infrastructure.Dtos
{
    public class MessageDto
    {
        public MessageDto(string title, string message)
        {
            Title = title;
            Message = message;
        }

        public MessageDto(string message)
        {
            Title = string.Empty;
            Message = message;
        }

        public string Title { get; set; }

        public string Message { get; set; }
    }
}
