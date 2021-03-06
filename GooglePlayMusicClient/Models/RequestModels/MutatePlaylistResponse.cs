﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace GooglePlayMusicAPI.Models.RequestModels
{
    [DataContract]
    public class MutatePlaylistResponse
    {
        [DataMember(Name = "mutate_response")]
        public List<MutateResponse> MutateResponses { get; set; }
    }
}
