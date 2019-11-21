using System;

namespace NoteMe.Common.Providers
{
    public interface IIdProvider
    {
        Guid Id { get; set; }
    }
}