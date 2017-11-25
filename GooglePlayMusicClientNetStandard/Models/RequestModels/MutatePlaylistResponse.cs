using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.RequestModels
{
    [DataContract]
    public class MutatePlaylistResponse
    {
        [DataMember(Name = "mutate_response")]
        public List<MutateResponse> MutateResponses { get; set; }
    }
}
