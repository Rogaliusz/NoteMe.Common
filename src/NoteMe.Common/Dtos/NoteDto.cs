using System;
using System.Collections.Generic;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.DataTypes.Providers;

namespace NoteMe.Common.Dtos
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
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }

        public Guid ActualNoteId { get; set; }
        public Guid UserId { get; set; }
        
        public ICollection<AttachmentDto> Attachments { get; set; } = new HashSet<AttachmentDto>();
    }
}