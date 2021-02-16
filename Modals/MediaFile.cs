using MediaOrganiser.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MediaOrganiser.Modals
{
    public class MediaFile
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public MediaType Type { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
    }
}
