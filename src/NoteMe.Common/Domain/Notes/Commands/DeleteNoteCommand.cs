using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Commands
{
    public class DeleteNoteCommand : 
        IAuthenticatedRequestProvider,
        IIdProvider,
        ICommandProvider
    {
        public Guid Id { get; set; }
        public Guid RequestBy { get; set; }
    }
}