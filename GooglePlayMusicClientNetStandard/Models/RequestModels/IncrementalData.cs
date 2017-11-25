using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GooglePlayMusicClientNetStandard.Models.RequestModels
{
    [DataContract]
    public class IncrementalData<T>
    {
        [DataMember(Name = "items")]
        public List<T> Items { get; set; }
    }
}
