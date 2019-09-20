using System;

namespace NoteMe.Common.Dtos
{
    public class JwtDto
    {
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public UserDto User { get; set; }
    }
}