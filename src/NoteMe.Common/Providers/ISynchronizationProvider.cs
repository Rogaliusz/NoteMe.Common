using System;
using NoteMe.Common.DataTypes.Enums;

namespace NoteMe.Common.Providers
{
    public interface ISynchronizationProvider : IIdProvider
    {
        DateTime? LastSynchronization { get; set; }
        bool NeedSynchronization { get; set; }
        
        SynchronizationStatusEnum StatusSynchronization { get; set; }
    }
}