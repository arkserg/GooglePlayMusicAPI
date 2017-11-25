using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels
{
    [DataContract]
    public class RadioSeed
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "curatedStationId")]
        public string CuratedStationId { get; set; }
        [DataMember(Name = "seedType")]
        public int SeedType { get; set; }
    }
}
