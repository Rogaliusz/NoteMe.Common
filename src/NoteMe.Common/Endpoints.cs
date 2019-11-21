namespace NoteMe.Common.DataTypes
{
    public static class Endpoints
    {
        public static string Login => $"{Users}login";
        public static string Users => $"{Api}users/";
        public static string Api => "/api/";

        public static class Attachments
        {
            public static string _ = $"{Api}notes/";
        }

        public static class Notes
        {
            public static string _ = $"{Api}notes/";
            public static string History = $"{_}history/";
        }
    }
}