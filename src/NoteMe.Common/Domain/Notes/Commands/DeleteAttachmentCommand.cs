using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Commands
{
    public class DeleteAttachmentCommand : IIdProvider, IAuthenticatedRequestProvider, ICommandProvider
    {
        public Guid Id { get; set; }
        public Guid RequestBy { get; set; }
    }
}