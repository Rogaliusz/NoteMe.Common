using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace NoteMe.Common.Services.Json
{
    public static class JsonSerializeService
    {
        private static JsonSerializerSettings _settings;
        private static IContractResolver _contractResolver;

        public static JsonSerializerSettings DefaultJsonSerializerSettings
            => _settings ?? (_settings = new JsonSerializerSettings
            {
                ContractResolver = CamelCaseContractResolver,
                TypeNameHandling = TypeNameHandling.None,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });

        public static IContractResolver CamelCaseContractResolver
            => _contractResolver ?? (_contractResolver = new NoteMeContractResolver());

        public static string Serialize(object obj)
            => JsonConvert.SerializeObject(obj, DefaultJsonSerializerSettings);

        public static TModel Deserialize<TModel>(string json)
            => JsonConvert.DeserializeObject<TModel>(json, DefaultJsonSerializerSettings);

    }
}