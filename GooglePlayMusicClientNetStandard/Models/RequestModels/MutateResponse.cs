using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.RequestModels
{
    [DataContract]
    public class MutateResponse
    {
        [DataMember(Name = "id")]
        public string ID { get; set; }
        [DataMember(Name = "client_id")]
        public string client_id { get; set; }
        [DataMember(Name = "response_code")]
        public string response_code { get; set; }
    }
}
