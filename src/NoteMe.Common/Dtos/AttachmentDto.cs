using System;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.DataTypes.Providers;

namespace NoteMe.Common.Dtos
{
    public class AttachmentDto : IDtoProvider,
        IIdProvider,
        IStatusProvider, 
        INameProvider
    {
        public Guid Id { get; set; }
        public StatusEnum Status { get; set; }
        public string Name { get; set; }
    }
}