using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace NewsReader
{
    static class Program
    {
        static async Task Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            var news = await GetNews();
            stopwatch.Stop();
            Console.WriteLine($"Parsed news in {stopwatch.ElapsedMilliseconds} ms.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static Task<News> GetNews(string url = "https://fortnitecontent-website-prod07.ol.epicgames.com/content/api/pages/fortnite-game")
        {
            return JsonHelper.GetUrl<News>(url);
        }
    }

    static class JsonHelper
    {
        static HttpClient Client = new HttpClient();

        public static async Task<T> GetUrl<T>(string url)
        {
            return Deserialize<T>(await Client.GetStringAsync(url));
        }

        public static T Deserialize<T>(string json) => JsonConvert.DeserializeObject<T>(json);
    }

    public sealed class News : BaseItem
    {
        public InternalMessageItem SurvivalMessage;
        public InternalMessageItem AthenaMessage;
        public SubGameSelectData SubGameSelectData;
        public SubGameNews SaveTheWorldNews;
        public SubGameNews BattleRoyaleNews;
        public LoginMessageItem LoginMessage;
        public PlaylistImagesItem PlaylistImages;
        public SubGameNews BattlePassAboutMessages;
        public PlaylistInformationItem PlaylistInformation;
        public TournamentInformation TournamentInformation;
        public SubGameNews EmergencyNotice;
        public KoreanCafe KoreanCafe;
        public CreativeAds CreativeAds;
    }

    public sealed class InternalMessageItem : BaseItem
    {
        public SimpleMessage OverrideableMessage;
    }

    public sealed class LoginMessageItem : BaseItem
    {
        public SimpleMessage LoginMessage;
    }

    public sealed class SimpleMessageBase : BaseMessage
    {
        public string Image;
        public string Title;
        public string Body;
        public string AdSpace;
        public SimpleMessageType MessageType;
        public string Layout;
        public bool Hidden;
        public bool Spotlight;
    }

    public enum SimpleMessageType
    {
        NONE,
        NORMAL,
        SALE
    }

    public sealed class SimplePlatformMessage : SimpleMessage
    {
        public string Platform;
    }

    public class SimpleMessage : BaseMessage
    {
        public SimpleMessageBase message;
    }

    public abstract class BaseMessage
    {
        [JsonProperty("_type")]
        public string Type;
    }

    public abstract class BaseItem
    {
        [JsonProperty("_title")]
        public string Title;

        public string Header;

        public string Style;

        [JsonProperty("_activeDate")]
        public DateTimeOffset ActiveDate;

        public DateTimeOffset LastModified;

        [JsonProperty("_locale")]
        public string Locale;
    }
}