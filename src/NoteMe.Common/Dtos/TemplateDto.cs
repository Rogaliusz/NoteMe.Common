using System;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.DataTypes.Providers;

namespace NoteMe.Common.Dtos
{
    public class TemplateDto : IDtoProvider,
        IIdProvider,
        IStatusProvider,
        INameProvider,
        ICreatedAtProvider
    {
        public Guid Id { get; set; }
        public StatusEnum Status { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public Guid UserId { get; set; }
    }
}