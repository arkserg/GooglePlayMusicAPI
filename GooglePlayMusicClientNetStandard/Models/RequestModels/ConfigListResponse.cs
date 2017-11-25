using System.Collections.Generic;
using System.Runtime.Serialization;
using GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels;

namespace GooglePlayMusicClientNetStandard.Models.RequestModels
{
    [DataContract]
    public class ConfigListResponse
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "data")]
        public ConfigList Data { get; set; }
    }

    [DataContract]
    public class ConfigList
    {
        [DataMember(Name = "entries")]
        public List<ConfigListEntry> Entries;
    }
   
}
