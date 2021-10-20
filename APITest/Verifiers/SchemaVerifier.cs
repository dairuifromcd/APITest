using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace APITest.Verifiers
{
    public static class SchemaVerifier
    {
        private static string SchemaFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent + "\\Schemas\\";

        public static bool IsValidFestivals(string content)
        {
            var schemaJson = File.ReadAllText(SchemaFolder + "FestivalsSchema.json");
            var schema = JSchema.Parse(schemaJson);
            var festivals = JArray.Parse(content);
            var result = festivals.IsValid(schema);

            return result;
        }
    }
}
