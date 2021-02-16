using Newtonsoft.Json;

namespace MediaOrganiser.Modals
{
    public class Image
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
