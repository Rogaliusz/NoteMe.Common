using System;

namespace NoteMe.Common.DataTypes.Providers
{
    public interface IModifiedAtProvider
    {
        DateTime ModifiedAt { get; set; }
    }
}