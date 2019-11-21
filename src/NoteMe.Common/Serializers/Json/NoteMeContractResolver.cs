using Newtonsoft.Json.Serialization;

namespace NoteMe.Common.Services.Json
{
    public class NoteMeContractResolver : DefaultContractResolver
    {
        public NoteMeContractResolver()
        {
            NamingStrategy = new CamelCaseNamingStrategy();
            IgnoreSerializableAttribute = true;
            IgnoreSerializableInterface = true;
            SerializeCompilerGeneratedMembers = true;
        }
    }
}