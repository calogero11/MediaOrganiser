using Newtonsoft.Json;
using System.Collections.Generic;

namespace MediaOrganiser.Modals
{
    public class Data
    {
        [JsonProperty("PlayLists")]
        public List<PlayList> PlayLists { get; set; }
    }
}
