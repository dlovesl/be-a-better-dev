﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace SOLID.OCP
{
    public class CamelCaseJsonSerializer : IDocumentSerializer
    {
        public string Serialize(Document doc)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            return JsonConvert.SerializeObject(doc, settings);
        }
    }
}
