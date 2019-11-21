using System;
using NoteMe.Common.Providers;

namespace NoteMe.Common.Domain.Notes.Queries
{
    public class GetNoteHistoryQuery : NoteMePaginationQueryBase, IAuthenticatedRequestProvider, IIdProvider
    {
        public Guid RequestBy { get; set; }
        public Guid Id { get; set; }
    }
}