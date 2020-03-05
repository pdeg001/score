using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Game
{

    public partial class RestoreCurrGame
    {
        [JsonProperty("p1Name")]
        public string P1Name { get; set; }

        [JsonProperty("p2Name")]
        public string P2Name { get; set; }

        [JsonProperty("p1Score")]
        public string P1Score { get; set; }

        [JsonProperty("p2Score")]
        public string P2Score { get; set; }

        [JsonProperty("p1Make")]
        public string P1Make { get; set; }

        [JsonProperty("p2Make")]
        public string P2Make { get; set; }

        [JsonProperty("innings")]
        public string Innings { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("playing")]
        public string Playing { get; set; }
    }

    public partial class RestoreCurrGame
    {
        public static RestoreCurrGame FromJson(string json) => JsonConvert.DeserializeObject<RestoreCurrGame>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RestoreCurrGame self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

