using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.DataTypes.Domain.Notes.Queries
{
    public class GetNoteQuery : IIdProvider, IAuthenticatedRequestProvider, IQueryProvider
    {
        public Guid Id { get; set; }
        public Guid RequestBy { get; set; }
    }
}