using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.DAL.Models;

// CoinRoot myDeserializedClass = JsonConvert.DeserializeObject<CoinRoot>(myJsonResponse);
public class Description
{

    [JsonProperty("en")]
    public string En { get; set; }

    [JsonProperty("de")]
    public string De { get; set; }

    [JsonProperty("es")]
    public string Es { get; set; }

    [JsonProperty("fr")]
    public string Fr { get; set; }

    [JsonProperty("it")]
    public string It { get; set; }

    [JsonProperty("pl")]
    public string Pl { get; set; }

    [JsonProperty("ro")]
    public string Ro { get; set; }

    [JsonProperty("hu")]
    public string Hu { get; set; }

    [JsonProperty("nl")]
    public string Nl { get; set; }

    [JsonProperty("pt")]
    public string Pt { get; set; }

    [JsonProperty("sv")]
    public string Sv { get; set; }

    [JsonProperty("vi")]
    public string Vi { get; set; }

    [JsonProperty("tr")]
    public string Tr { get; set; }

    [JsonProperty("ru")]
    public string Ru { get; set; }

    [JsonProperty("ja")]
    public string Ja { get; set; }

    [JsonProperty("zh")]
    public string Zh { get; set; }

    [JsonProperty("zh-tw")]
    public string ZhTw { get; set; }

    [JsonProperty("ko")]
    public string Ko { get; set; }

    [JsonProperty("ar")]
    public string Ar { get; set; }

    [JsonProperty("th")]
    public string Th { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("cs")]
    public string Cs { get; set; }

    [JsonProperty("da")]
    public string Da { get; set; }

    [JsonProperty("el")]
    public string El { get; set; }

    [JsonProperty("hi")]
    public string Hi { get; set; }

    [JsonProperty("no")]
    public string No { get; set; }

    [JsonProperty("sk")]
    public string Sk { get; set; }

    [JsonProperty("uk")]
    public string Uk { get; set; }

    [JsonProperty("he")]
    public string He { get; set; }

    [JsonProperty("fi")]
    public string Fi { get; set; }

    [JsonProperty("bg")]
    public string Bg { get; set; }

    [JsonProperty("hr")]
    public string Hr { get; set; }

    [JsonProperty("lt")]
    public string Lt { get; set; }

    [JsonProperty("sl")]
    public string Sl { get; set; }
}



public class Image
{
    [JsonProperty("thumb")]
    public string Thumb { get; set; }

    [JsonProperty("small")]
    public string Small { get; set; }

    [JsonProperty("large")]
    public string Large { get; set; }
}

public class Links
{
    [JsonProperty("homepage")]
    public List<string> Homepage { get; set; }

    [JsonProperty("whitepaper")]
    public string Whitepaper { get; set; }

    [JsonProperty("blockchain_site")]
    public List<string> BlockchainSite { get; set; }

    [JsonProperty("official_forum_url")]
    public List<string> OfficialForumUrl { get; set; }

    [JsonProperty("chat_url")]
    public List<string> ChatUrl { get; set; }

    [JsonProperty("announcement_url")]
    public List<string> AnnouncementUrl { get; set; }

    [JsonProperty("twitter_screen_name")]
    public string TwitterScreenName { get; set; }

    [JsonProperty("facebook_username")]
    public string FacebookUsername { get; set; }

    [JsonProperty("bitcointalk_thread_identifier")]
    public object BitcointalkThreadIdentifier { get; set; }

    [JsonProperty("telegram_channel_identifier")]
    public string TelegramChannelIdentifier { get; set; }

    [JsonProperty("subreddit_url")]
    public string SubredditUrl { get; set; }

    [JsonProperty("repos_url")]
    public ReposUrl ReposUrl { get; set; }
}

public class Localization
{
    [JsonProperty("en")]
    public string En { get; set; }

    [JsonProperty("de")]
    public string De { get; set; }

    [JsonProperty("es")]
    public string Es { get; set; }

    [JsonProperty("fr")]
    public string Fr { get; set; }

    [JsonProperty("it")]
    public string It { get; set; }

    [JsonProperty("pl")]
    public string Pl { get; set; }

    [JsonProperty("ro")]
    public string Ro { get; set; }

    [JsonProperty("hu")]
    public string Hu { get; set; }

    [JsonProperty("nl")]
    public string Nl { get; set; }

    [JsonProperty("pt")]
    public string Pt { get; set; }

    [JsonProperty("sv")]
    public string Sv { get; set; }

    [JsonProperty("vi")]
    public string Vi { get; set; }

    [JsonProperty("tr")]
    public string Tr { get; set; }

    [JsonProperty("ru")]
    public string Ru { get; set; }

    [JsonProperty("ja")]
    public string Ja { get; set; }

    [JsonProperty("zh")]
    public string Zh { get; set; }

    [JsonProperty("zh-tw")]
    public string ZhTw { get; set; }

    [JsonProperty("ko")]
    public string Ko { get; set; }

    [JsonProperty("ar")]
    public string Ar { get; set; }

    [JsonProperty("th")]
    public string Th { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("cs")]
    public string Cs { get; set; }

    [JsonProperty("da")]
    public string Da { get; set; }

    [JsonProperty("el")]
    public string El { get; set; }

    [JsonProperty("hi")]
    public string Hi { get; set; }

    [JsonProperty("no")]
    public string No { get; set; }

    [JsonProperty("sk")]
    public string Sk { get; set; }

    [JsonProperty("uk")]
    public string Uk { get; set; }

    [JsonProperty("he")]
    public string He { get; set; }

    [JsonProperty("fi")]
    public string Fi { get; set; }

    [JsonProperty("bg")]
    public string Bg { get; set; }

    [JsonProperty("hr")]
    public string Hr { get; set; }

    [JsonProperty("lt")]
    public string Lt { get; set; }

    [JsonProperty("sl")]
    public string Sl { get; set; }
}



public class ReposUrl
{
    [JsonProperty("github")]
    public List<string> Github { get; set; }

    [JsonProperty("bitbucket")]
    public List<object> Bitbucket { get; set; }
}

public class CoinRoot
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("symbol")]
    public string Symbol { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("web_slug")]
    public string WebSlug { get; set; }

    [JsonProperty("asset_platform_id")]
    public object AssetPlatformId { get; set; }

    [JsonProperty("block_time_in_minutes")]
    public int? BlockTimeInMinutes { get; set; }

    [JsonProperty("hashing_algorithm")]
    public string HashingAlgorithm { get; set; }

    [JsonProperty("categories")]
    public List<string> Categories { get; set; }

    [JsonProperty("preview_listing")]
    public bool? PreviewListing { get; set; }

    [JsonProperty("public_notice")]
    public object PublicNotice { get; set; }

    [JsonProperty("additional_notices")]
    public List<object> AdditionalNotices { get; set; }

    [JsonProperty("localization")]
    public Localization Localization { get; set; }

    [JsonProperty("description")]
    public Description Description { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }

    [JsonProperty("image")]
    public Image Image { get; set; }

    [JsonProperty("country_origin")]
    public string CountryOrigin { get; set; }

    [JsonProperty("genesis_date")]
    public string GenesisDate { get; set; }

    [JsonProperty("sentiment_votes_up_percentage")]
    public double? SentimentVotesUpPercentage { get; set; }

    [JsonProperty("sentiment_votes_down_percentage")]
    public double? SentimentVotesDownPercentage { get; set; }

    [JsonProperty("watchlist_portfolio_users")]
    public int? WatchlistPortfolioUsers { get; set; }

    [JsonProperty("market_cap_rank")]
    public int? MarketCapRank { get; set; }

    [JsonProperty("status_updates")]
    public List<object> StatusUpdates { get; set; }

    [JsonProperty("last_updated")]
    public DateTime? LastUpdated { get; set; }
}



