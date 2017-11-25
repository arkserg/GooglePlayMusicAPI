using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.RequestModels
{
    [DataContract]
    public class IncrementalResponse<T>
    {
        [DataMember(Name = "data")]
        public IncrementalData<T> Data { get; set; }
        [DataMember(Name = "kind")]
        public string Kind { get; set; }
        [DataMember(Name = "nextPageToken")]
        public string NextPageToken { get; set; }
    }
}
