using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Queries
{
    public class GetNotesQuery : NoteMePaginationQueryBase, IAuthenticatedRequestProvider
    {
        public Guid RequestBy { get; set; }
    }
}