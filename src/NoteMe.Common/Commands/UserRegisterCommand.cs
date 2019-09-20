using System;
using NoteMe.Common.DataTypes.Providers;

namespace NoteMe.Common.Commands
{
    public class UserRegisterCommand : 
        IDtoProvider,
        IIdProvider
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}