namespace NoteMe.Common.DataTypes
{
    public static class Endpoints
    {
        public static string Login => $"{Users}/Login";
        public static string Users => $"{Api}/users";
        public static string Api => "/api";
    }
}