using Newtonsoft.Json;

namespace MediaOrganiser.Modals
{
    public class Category
    {
        public Category()
        {

        }

        public Category(string name)
        {
            Name = name;
        }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
