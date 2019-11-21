using System;
using NoteMe.Common.DataTypes.Enums;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Commands
{
    public class CreateAttachmentCommand : ICommandProvider, 
        IAuthenticatedRequestProvider,
        INameProvider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid RequestBy { get; set; }
        public AttachmentTypeEnum Type { get; set; }
        public Guid NoteId { get; set; }
    }
}