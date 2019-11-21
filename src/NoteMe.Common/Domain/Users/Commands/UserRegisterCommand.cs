using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Users.Commands
{
    public class UserRegisterCommand : 
        IDtoProvider,
        IIdProvider,
        ICommandProvider
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}