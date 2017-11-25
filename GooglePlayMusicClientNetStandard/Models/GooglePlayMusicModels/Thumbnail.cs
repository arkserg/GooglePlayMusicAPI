using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels
{
    [DataContract]
    public class Thumbnail
    {
        [DataMember(Name = "url")]
        public string Url { get; set; }
        [DataMember(Name = "width")]
        public int Width { get; set; }
        [DataMember(Name = "height")]
        public int Height { get; set; }
    }
}
