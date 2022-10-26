using BoxHeadTracker.Data;
using System.Text.Json.Serialization;

namespace BoxHeadTracker.Data
{
    public class Translations
    {
        public string en { get; set; }
        public string fr { get; set; }
        public string it { get; set; }
        public string de { get; set; }
        public string es { get; set; }
        public string pt { get; set; }
        public string ru { get; set; }
        public string pl { get; set; }
        public string uk { get; set; }
        public string tr { get; set; }
        public string ja { get; set; }
        public string zh { get; set; }
        public string ko { get; set; }
        public string tc { get; set; }
    }

    public class News
    {
        public string id { get; set; }
        public string message { get; set; }
        public string link { get; set; }
        public string imageLink { get; set; }
        public bool priority { get; set; }
        public DateTime date { get; set; }
        public string eta { get; set; }
        public bool update { get; set; }
        public bool primeAccess { get; set; }
        public bool stream { get; set; }
        public Translations translations { get; set; }
        public string asString { get; set; }
        public DateTime? endDate { get; set; }
        public DateTime? startDate { get; set; }
    }

    public class Metadata
    {
    }

    public class NextAlt
    {
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
    }

    public class Event
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public int maximumScore { get; set; }
        public int currentScore { get; set; }
        public object smallInterval { get; set; }
        public object largeInterval { get; set; }
        public string description { get; set; }
        public string tooltip { get; set; }
        public string node { get; set; }
        public IList<object> concurrentNodes { get; set; }
        public IList<Reward> rewards { get; set; }
        public bool expired { get; set; }
        public IList<object> interimSteps { get; set; }
        public IList<object> progressSteps { get; set; }
        public bool isPersonal { get; set; }
        public IList<object> regionDrops { get; set; }
        public IList<string> archwingDrops { get; set; }
        public string asString { get; set; }
        public Metadata metadata { get; set; }
        public IList<object> completionBonuses { get; set; }
        public DateTime altExpiry { get; set; }
        public DateTime altActivation { get; set; }
        public NextAlt nextAlt { get; set; }
        public string faction { get; set; }
        public string victimNode { get; set; }
        public string scoreLocTag { get; set; }
        public double? health { get; set; }
        public string scoreVar { get; set; }
    }

    public class Variant
    {
        public string missionType { get; set; }
        public string modifier { get; set; }
        public string modifierDescription { get; set; }
        public string node { get; set; }
    }

    public class Sortie
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public string rewardPool { get; set; }
        public IList<Variant> variants { get; set; }
        public IList<object> missions { get; set; }
        public string boss { get; set; }
        public string faction { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
    }

    public class Job
    {
        public string id { get; set; }
        public IList<string> rewardPool { get; set; }
        public string type { get; set; }
        public IList<int> enemyLevels { get; set; }
        public IList<int> standingStages { get; set; }
        public int minMR { get; set; }
        public DateTime expiry { get; set; }
        public string timeBound { get; set; }
        public bool? isVault { get; set; }
        public string locationTag { get; set; }
        public string timeBoound { get; set; }
    }

    public class SyndicateMission
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public string syndicate { get; set; }
        public string syndicateKey { get; set; }
        public IList<string> nodes { get; set; }
        public IList<Job> jobs { get; set; }
        public string eta { get; set; }
    }

    public class Fissure
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public string node { get; set; }
        public string missionType { get; set; }
        public string missionKey { get; set; }
        public string enemy { get; set; }
        public string enemyKey { get; set; }
        public string nodeKey { get; set; }
        public string tier { get; set; }
        public int tierNum { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
        public bool isStorm { get; set; }
        public bool isHard { get; set; }
    }

    public class FlashSale
    {
        public string item { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public int discount { get; set; }
        public int regularOverride { get; set; }
        public int premiumOverride { get; set; }
        public bool isShownInMarket { get; set; }
        public bool isFeatured { get; set; }
        public bool isPopular { get; set; }
        public string id { get; set; }
        public bool expired { get; set; }
        public string eta { get; set; }
    }

    public class AttackerReward
    {
        public IList<object> items { get; set; }
        public IList<CountedItem> countedItems { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string itemString { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
    }

    public class Reward
    {
        public IList<object> items { get; set; }
        public IList<CountedItem> countedItems { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string itemString { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
    }

    public class Attacker
    {
        public Reward reward { get; set; }
        public string faction { get; set; }
        public string factionKey { get; set; }
    }

    public class CountedItem
    {
        public int count { get; set; }
        public string type { get; set; }
        public string key { get; set; }
    }

    public class DefenderReward
    {
        public IList<object> items { get; set; }
        public IList<CountedItem> countedItems { get; set; }
        public int credits { get; set; }
        public string asString { get; set; }
        public string itemString { get; set; }
        public string thumbnail { get; set; }
        public int color { get; set; }
    }

    public class Defender
    {
        public Reward reward { get; set; }
        public string faction { get; set; }
        public string factionKey { get; set; }
    }

    public class Invasion
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public string node { get; set; }
        public string nodeKey { get; set; }
        public string desc { get; set; }
        public AttackerReward attackerReward { get; set; }
        public string attackingFaction { get; set; }
        public Attacker attacker { get; set; }
        public DefenderReward defenderReward { get; set; }
        public string defendingFaction { get; set; }
        public Defender defender { get; set; }
        public bool vsInfestation { get; set; }
        public int count { get; set; }
        public int requiredRuns { get; set; }
        public double completion { get; set; }
        public bool completed { get; set; }
        public string eta { get; set; }
        public IList<string> rewardTypes { get; set; }
    }

    public class VoidTrader
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public string character { get; set; }
        public string location { get; set; }
        public IList<object> inventory { get; set; }
        public string psId { get; set; }
        public string endString { get; set; }
        public DateTime initialStart { get; set; }
        public IList<object> schedule { get; set; }
    }

    public class DailyDeal
    {
        public string item { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public int originalPrice { get; set; }
        public int salePrice { get; set; }
        public int total { get; set; }
        public int sold { get; set; }
        public string id { get; set; }
        public string eta { get; set; }
        public int discount { get; set; }
    }

    public class Simaris
    {
        public string target { get; set; }
        public bool isTargetActive { get; set; }
        public string asString { get; set; }
    }

    public class ConclaveChallenge
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public int amount { get; set; }
        public string mode { get; set; }
        public string category { get; set; }
        public string eta { get; set; }
        public bool expired { get; set; }
        public bool daily { get; set; }
        public bool rootChallenge { get; set; }
        public string endString { get; set; }
        public string description { get; set; }
        public string title { get; set; }
        public int standing { get; set; }
        public string asString { get; set; }
    }

    public class EarthCycle
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public bool isDay { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }
    }

    public class CetusCycle
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public bool isDay { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }
        public bool isCetus { get; set; }
        public string shortString { get; set; }
    }

    public class CambionCycle
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public DateTime expiry { get; set; }
        public string timeLeft { get; set; }
        public string active { get; set; }
    }

    public class ZarimanCycle
    {
        public string id { get; set; }
        public DateTime bountiesEndDate { get; set; }
        public DateTime expiry { get; set; }
        public DateTime activation { get; set; }
        public bool isCorpus { get; set; }
        public string state { get; set; }
        public string timeLeft { get; set; }
        public string shortString { get; set; }
    }

    public class ConstructionProgress
    {
        public string id { get; set; }
        public string fomorianProgress { get; set; }
        public string razorbackProgress { get; set; }
        public string unknownProgress { get; set; }
    }

    public class VallisCycle
    {
        public string id { get; set; }
        public DateTime expiry { get; set; }
        public bool isWarm { get; set; }
        public string state { get; set; }
        public DateTime activation { get; set; }
        public string timeLeft { get; set; }
        public string shortString { get; set; }
    }

    public class Params
    {
    }

    public class ActiveChallenge
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public bool isDaily { get; set; }
        public bool isElite { get; set; }
        public string desc { get; set; }
        public string title { get; set; }
        public int reputation { get; set; }
    }

    public class Nightwave
    {
        public string id { get; set; }
        public DateTime activation { get; set; }
        public string startString { get; set; }
        public DateTime expiry { get; set; }
        public bool active { get; set; }
        public int season { get; set; }
        public string tag { get; set; }
        public int phase { get; set; }
        [JsonPropertyName("params")]
        public Params parameters { get; set; }
    public IList<object> possibleChallenges { get; set; }
    public IList<ActiveChallenge> activeChallenges { get; set; }
    public IList<string> rewardTypes { get; set; }
}

public class Arbitration
{
    public DateTime activation { get; set; }
    public DateTime expiry { get; set; }
    public string enemy { get; set; }
    public string type { get; set; }
    public bool archwing { get; set; }
    public bool sharkwing { get; set; }
    public string node { get; set; }
    public string nodeKey { get; set; }
    public string typeKey { get; set; }
    public string id { get; set; }
    public bool expired { get; set; }
}

public class SentientMission
{
    public string node { get; set; }
    public string faction { get; set; }
    public string type { get; set; }
}

public class SentientOutposts
{
    public SentientMission mission { get; set; }
    public DateTime activation { get; set; }
    public DateTime expiry { get; set; }
    public bool active { get; set; }
    public string id { get; set; }
}

public class CurrentReward
{
    public string name { get; set; }
    public int cost { get; set; }
}

public class Rotation
{
    public string name { get; set; }
    public int cost { get; set; }
}

public class Evergreen
{
    public string name { get; set; }
    public int cost { get; set; }
}

public class Incursions
{
    public string id { get; set; }
    public DateTime activation { get; set; }
    public DateTime expiry { get; set; }
}

public class SteelPath
{
    public CurrentReward currentReward { get; set; }
    public DateTime activation { get; set; }
    public DateTime expiry { get; set; }
    public string remaining { get; set; }
    public IList<Rotation> rotation { get; set; }
    public IList<Evergreen> evergreens { get; set; }
    public Incursions incursions { get; set; }
}

public class Inventory
{
    public string item { get; set; }
    public int? ducats { get; set; }
    public int? credits { get; set; }
}

public class Schedule
{
    public DateTime expiry { get; set; }
    public string item { get; set; }
}

public class VaultTrader
{
    public string id { get; set; }
    public DateTime activation { get; set; }
    public string startString { get; set; }
    public DateTime expiry { get; set; }
    public bool active { get; set; }
    public string character { get; set; }
    public string location { get; set; }
    public IList<Inventory> inventory { get; set; }
    public string psId { get; set; }
    public string endString { get; set; }
    public DateTime initialStart { get; set; }
    public bool completed { get; set; }
    public IList<Schedule> schedule { get; set; }
}

public class Mission
{
    public string node { get; set; }
    public string nodeKey { get; set; }
    public string type { get; set; }
    public string typeKey { get; set; }
    public bool nightmare { get; set; }
    public bool archwingRequired { get; set; }
    public bool isSharkwing { get; set; }
    public IList<object> advancedSpawners { get; set; }
    public IList<object> requiredItems { get; set; }
    public IList<object> levelAuras { get; set; }
}

public class ArchonHunt
{
    public string id { get; set; }
    public DateTime activation { get; set; }
    public string startString { get; set; }
    public DateTime expiry { get; set; }
    public bool active { get; set; }
    public string rewardPool { get; set; }
    public IList<object> variants { get; set; }
    public IList<Mission> missions { get; set; }
    public string boss { get; set; }
    public string faction { get; set; }
    public bool expired { get; set; }
    public string eta { get; set; }
}

public class WorldState
{
    public DateTime timestamp { get; set; }
    public IList<News> news { get; set; }
    public IList<Event> events { get; set; }
    public IList<object> alerts { get; set; }
    public Sortie sortie { get; set; }
    public IList<SyndicateMission> syndicateMissions { get; set; }
    public IList<Fissure> fissures { get; set; }
    public IList<object> globalUpgrades { get; set; }
    public IList<FlashSale> flashSales { get; set; }
    public IList<Invasion> invasions { get; set; }
    public IList<object> darkSectors { get; set; }
    public VoidTrader voidTrader { get; set; }
    public IList<DailyDeal> dailyDeals { get; set; }
    public Simaris simaris { get; set; }
    public IList<ConclaveChallenge> conclaveChallenges { get; set; }
    public IList<object> persistentEnemies { get; set; }
    public EarthCycle earthCycle { get; set; }
    public CetusCycle cetusCycle { get; set; }
    public CambionCycle cambionCycle { get; set; }
    public ZarimanCycle zarimanCycle { get; set; }
    public IList<object> weeklyChallenges { get; set; }
    public ConstructionProgress constructionProgress { get; set; }
    public VallisCycle vallisCycle { get; set; }
    public Nightwave nightwave { get; set; }
    public IList<object> kuva { get; set; }
    public Arbitration arbitration { get; set; }
    public SentientOutposts sentientOutposts { get; set; }
    public SteelPath steelPath { get; set; }
    public VaultTrader vaultTrader { get; set; }
    public ArchonHunt archonHunt { get; set; }
}


}