using Newtonsoft.Json;

namespace NewsReader
{
    public sealed class CreativeAds : BaseItem
    {
        [JsonProperty("ad_info")]
        public CreativeAdsList AdInfo;
    }

    public sealed class CreativeAdsList : BaseMessage
    {
        public CreativeAdInformation[] Ads;
    }

    public sealed class CreativeAdInformation : BaseMessage
    {
        [JsonProperty("sub_header")]
        public string SubHeader;
        public string Image;
        public string Description;
        public string Header;
    }
}
