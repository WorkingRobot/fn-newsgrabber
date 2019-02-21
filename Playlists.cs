using Newtonsoft.Json;

namespace NewsReader
{
    public sealed class PlaylistImagesItem : BaseItem
    {
        public PlaylistImagesList PlaylistImages;
    }

    public sealed class PlaylistImagesList : BaseMessage
    {
        public PlaylistImage[] Images;
    }

    public sealed class PlaylistImage : BaseMessage
    {
        public string Image;
        public string PlaylistName;
    }

    public sealed class PlaylistInformationItem : BaseItem
    {
        [JsonProperty("frontend_matchmaking_header_style")]
        public string FrontendMatchmakingHeaderStyle;

        [JsonProperty("frontend_matchmaking_header_text")]
        public string FrontendMatchmakingHeaderText;

        [JsonProperty("playlist_info")]
        public PlaylistInformationList PlaylistInfo;
    }

    public sealed class PlaylistInformationList : BaseMessage
    {
        public PlaylistInformation[] Playlists;
    }

    public sealed class PlaylistInformation : BaseMessage
    {
        public string Image;

        [JsonProperty("playlist_name")]
        public string PlaylistName;
        public string Description;
        public string Violator;

        [JsonProperty("special_border")]
        public string SpecialBorder;

        [JsonProperty("display_name")]
        public string DisplayName;

        [JsonProperty("extra_images")]
        public string[] ExtraImages;
    }
}
