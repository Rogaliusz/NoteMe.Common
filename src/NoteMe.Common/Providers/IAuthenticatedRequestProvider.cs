
using System;

namespace NoteMe.Common.Providers
{
    public interface IAuthenticatedRequestProvider
    {
        Guid RequestBy { get; set; }
    }
}