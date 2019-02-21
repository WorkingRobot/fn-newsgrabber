using Newtonsoft.Json;

namespace NewsReader
{
    public sealed class TournamentInformation : BaseItem
    {
        [JsonProperty("tournament_info")]
        public TournamentInformationList TournamentInfo;
    }

    public sealed class TournamentInformationList : BaseMessage
    {
        public TournamentDisplayInfo[] Tournaments;
    }

    public sealed class TournamentDisplayInfo : BaseMessage
    {
        [JsonProperty("background_text_color")]
        public string BackgroundTextColor;

        [JsonProperty("poster_back_image")]
        public string PosterBackImage;

        [JsonProperty("flavor_description")]
        public string FlavorDescription;

        [JsonProperty("poster_front_image")]
        public string PosterFrontImage;

        [JsonProperty("short_format_title")]
        public string ShortFormatTitle;

        [JsonProperty("title_line_1")]
        public string TitleLine1;

        [JsonProperty("title_line_2")]
        public string TitleLine2;

        [JsonProperty("details_description")]
        public string DetailsDescription;

        [JsonProperty("long_format_title")]
        public string LongFormatTitle;

        [JsonProperty("poster_fade_color")]
        public string PosterFadeColor;

        [JsonProperty("secondary_color")]
        public string SecondaryColor;

        [JsonProperty("pin_score_requirement")]
        public int PinScoreRequirement;

        [JsonProperty("title_color")]
        public string TitleColor;

        [JsonProperty("loading_screen_image")]
        public string LoadingScreenImage;

        [JsonProperty("background_right_color")]
        public string BackgroundRightColor;

        [JsonProperty("pin_earned_text")]
        public string PinEarnedText;

        [JsonProperty("tournament_display_id")]
        public string TournamentDisplayId;

        [JsonProperty("highlight_color")]
        public string HighlightColor;

        [JsonProperty("schedule_info")]
        public string ScheduleInfo;

        [JsonProperty("primary_color")]
        public string PrimaryColor;

        [JsonProperty("shadow_color")]
        public string ShadowColor;

        [JsonProperty("background_left_color")]
        public string BackgroundLeftColor;

        [JsonProperty("playlist_title_image")]
        public string PlaylistTitleImage;

        [JsonProperty("base_color")]
        public string BaseColor;
    }
}
