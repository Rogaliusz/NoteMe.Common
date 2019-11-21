using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Users.Dto
{
    public class JwtDto : IIdProvider,
        IDtoProvider
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
        public DateTime Expires { get; set; }
        public UserDto User { get; set; }
    }
}