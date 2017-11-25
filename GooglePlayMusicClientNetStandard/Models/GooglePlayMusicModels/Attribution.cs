using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.GooglePlayMusicModels
{
    [DataContract]
    public class Attribution
    {
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "source_title")]
        public string SourceTitle { get; set; }
        [DataMember(Name = "source_url")]
        public string SourceUrl { get; set; }
        [DataMember(Name = "license_title")]
        public string LicenceTitle { get; set; }
        [DataMember(Name = "license_url")]
        public string LicenseUrl { get; set; }
    }
}
