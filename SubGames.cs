using Newtonsoft.Json;

namespace NewsReader
{
    public sealed class SubGameSelectData : BaseItem
    {
        public SimpleMessage SaveTheWorldUnowned;
        public SimpleMessage SaveTheWorld;
        public SimpleMessage BattleRoyale;
        public SimpleMessage Creative;
    }

    public sealed class SubGameNews : BaseItem
    {
        public SubGameNewsList News;
    }

    public sealed class SubGameNewsList : BaseMessage
    {
        public SimpleMessageBase[] Messages;

        [JsonProperty("platform_messages")]
        public SimplePlatformMessage[] PlatformMessages;
    }
}
