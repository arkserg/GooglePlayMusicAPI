using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels
{
    [DataContract]
    public class Image
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "url")]
        public string Url { get; set; }
        [DataMember(Name = "aspectRatio")]
        public int AspectRatio { get; set; }
        [DataMember(Name = "autogen")]
        public bool Autogen { get; set; }
    }
}
