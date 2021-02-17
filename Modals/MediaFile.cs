using MediaOrganiser.Enums;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MediaOrganiser.Modals
{
    public class MediaFile
    {
        public MediaFile()
        {

        }

        public MediaFile(
            string name,
            string path,
            string type,
            string comment,
            Image image,
            List<Category> categories)
        {
            Name = name;
            Path = path;
            Type = type;
            Comment = comment;
            Image = image;
            Categories = categories;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("comment")]
        public string Comment { get; set; }

        [JsonProperty("image")]
        public Image Image { get; set; }

        [JsonProperty("categories")]
        public List<Category> Categories { get; set; }
    }
}
