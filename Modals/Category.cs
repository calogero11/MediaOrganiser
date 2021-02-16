using Newtonsoft.Json;

namespace MediaOrganiser.Modals
{
    public class Category
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
