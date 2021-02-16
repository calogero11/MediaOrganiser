using Newtonsoft.Json;
using System.Collections.Generic;

namespace MediaOrganiser.Modals
{
    public class PlayList
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mediaFiles")]
        public List<MediaFile> MediaFiles { get; set; }
    }
}
