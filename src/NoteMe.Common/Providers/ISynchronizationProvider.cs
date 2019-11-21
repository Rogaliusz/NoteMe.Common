using System;

namespace NoteMe.Common.Providers
{
    public interface ISynchronizationProvider : IIdProvider
    {
        DateTime? LastSynchronization { get; set; }
        bool NeedSynchronization { get; set; }
    }
}