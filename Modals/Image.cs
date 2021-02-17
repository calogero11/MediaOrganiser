using Newtonsoft.Json;

namespace MediaOrganiser.Modals
{
    public class Image
    {
        public Image()
        {

        }

        public Image(string name,
            string path)
        {
            Name = name;
            Path = path;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }
    }
}
