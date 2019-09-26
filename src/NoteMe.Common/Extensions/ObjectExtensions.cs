using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using NoteMe.Common.Services.Json;

namespace NoteMe.Common.Extensions
{
    public static class ObjectExtensions
    {
        public static StringContent GetPayload(this object data, IContractResolver contractResolver)
        {
            var serializeSettings =  new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            var json = JsonSerializeService.Serialize(data);
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}