using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Commands
{
    public class UpdateNoteCommand : IAuthenticatedRequestProvider, IIdProvider, ICommandProvider
    {
        public Guid RequestBy { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}