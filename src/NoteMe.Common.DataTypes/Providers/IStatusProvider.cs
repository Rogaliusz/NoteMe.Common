using NoteMe.Common.DataTypes.Enums;

namespace NoteMe.Common.DataTypes.Providers
{
    public interface IStatusProvider
    {
        StatusEnum Status { get; set; }
    }
}