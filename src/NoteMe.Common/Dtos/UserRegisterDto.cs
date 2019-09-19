using System;
using NoteMe.Common.DataTypes.Providers;

namespace NoteMe.Common.Dtos
{
    public class UserRegisterDto : IDtoProvider,
        IIdProvider,
        INameProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EMmil { get; set; }
    }
}