using Newtonsoft.Json;

namespace NewsReader
{
    public sealed class KoreanCafe : BaseItem
    {
        [JsonProperty("cafe_info")]
        public KoreanCafeList CafeInfo;
    }

    public sealed class KoreanCafeList : BaseMessage
    {
        public KoreanCafeInformation[] Cafes;
    }

    public sealed class KoreanCafeInformation : BaseMessage
    {
        [JsonProperty("korean_cafe")]
        public string KoreanCafe;

        [JsonProperty("korean_cafe_description")]
        public string KoreanCafeDescription;

        [JsonProperty("korean_cafe_header")]
        public string KoreanCafeHeader;
    }
}
