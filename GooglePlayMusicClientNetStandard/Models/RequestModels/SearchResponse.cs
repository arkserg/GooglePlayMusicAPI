using System.Collections.Generic;
using System.Runtime.Serialization;
using GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels;

namespace GooglePlayMusicClientNetStandard.Models.RequestModels
{
    [DataContract]
    public class SearchResponse
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "clusterOrder")]
        public List<string> ClusterOrder { get; set; }
        [DataMember(Name = "suggestedQuery")]
        public string SuggestedQuery { get; set; }
        [DataMember(Name = "entries")]
        public List<SearchEntry> Entries { get; set; }
    }
}

