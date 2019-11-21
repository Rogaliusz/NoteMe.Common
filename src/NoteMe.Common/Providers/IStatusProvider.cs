using NoteMe.Common.DataTypes.Enums;

namespace NoteMe.Common.Providers
{
    public interface IStatusProvider
    {
        StatusEnum Status { get; set; }
    }
}