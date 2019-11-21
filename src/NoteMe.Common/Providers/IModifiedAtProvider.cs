using System;

namespace NoteMe.Common.Providers
{
    public interface IModifiedAtProvider
    {
        DateTime ModifiedAt { get; set; }
    }
}