using System;

namespace NoteMe.Common.DataTypes.Providers
{
    public interface ICreatedAtProvider
    {
        DateTime CreatedAt { get; set; }
    }
}