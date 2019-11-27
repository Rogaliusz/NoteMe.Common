using System;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Dto
{
    public class AttachmentDto : IDtoProvider,
        IIdProvider,
        IStatusProvider, 
        INameProvider,
        ICreatedAtProvider
    {
        public Guid Id { get; set; }
        public StatusEnum Status { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid NoteId { get; set; }
    }
}