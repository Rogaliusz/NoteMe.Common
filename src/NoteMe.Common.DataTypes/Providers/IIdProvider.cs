using System;

namespace NoteMe.Common.DataTypes.Providers
{
    public interface IIdProvider
    {
        Guid Id { get; set; }
    }
}