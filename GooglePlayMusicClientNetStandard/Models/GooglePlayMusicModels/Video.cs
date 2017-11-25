using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels
{
    [DataContract]
    public class Video
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
        [DataMember(Name = "thumbnails")]
        public List<Thumbnail> Thumbnails { get; set; }
    }
}
