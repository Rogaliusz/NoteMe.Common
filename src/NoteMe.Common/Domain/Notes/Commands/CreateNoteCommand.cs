using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Commands
{
    public class CreateNoteCommand : IAuthenticatedRequestProvider,
        IIdProvider,
        ICommandProvider
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Content { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public Guid RequestBy { get; set; }
    }
}