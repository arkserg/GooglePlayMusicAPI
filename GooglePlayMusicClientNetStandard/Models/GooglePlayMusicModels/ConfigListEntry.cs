using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels
{
    [DataContract]
    public class ConfigListEntry
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}
