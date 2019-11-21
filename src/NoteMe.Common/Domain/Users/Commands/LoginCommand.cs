using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Users.Commands
{
    public class LoginCommand : ICommandProvider
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Email { get; set; }
        public string Password { get; set; }
    }
}