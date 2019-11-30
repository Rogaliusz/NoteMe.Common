using System;
using System.Collections.Generic;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Dto
{
    public class NoteDto : IDtoProvider,
        IIdProvider, 
        INameProvider, 
        ICreatedAtProvider, 
        IStatusProvider,
        IModifiedAtProvider
    {
        public Guid Id { get; set; }
        public StatusEnum Status { get; set; }
        public string Name { get; set; }
        public string Tags { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Guid? ActualNoteId { get; set; }
        public Guid UserId { get; set; }
        
        public ICollection<AttachmentDto> Attachments { get; set; } = new HashSet<AttachmentDto>();
        public ICollection<NoteDto> OldNotes { get; set; } = new HashSet<NoteDto>();
    }
}