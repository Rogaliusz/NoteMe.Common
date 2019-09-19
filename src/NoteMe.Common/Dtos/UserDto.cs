using System;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.DataTypes.Providers;

namespace NoteMe.Common.Dtos
{
    public class UserDto : IDtoProvider,
        IIdProvider,
        INameProvider,
        IStatusProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public StatusEnum Status { get; set; }
    }
}