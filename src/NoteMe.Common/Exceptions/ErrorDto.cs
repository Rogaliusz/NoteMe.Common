namespace NoteMe.Common.Exceptions
{
    public class ErrorDto
    {
        public string ErrorCode { get; set; }
        public object Details { get; set; }
        public string Stack { get; set; }
    }
}