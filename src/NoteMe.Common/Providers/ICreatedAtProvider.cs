using System;

namespace NoteMe.Common.Providers
{
    public interface ICreatedAtProvider
    {
        DateTime CreatedAt { get; set; }
    }
}