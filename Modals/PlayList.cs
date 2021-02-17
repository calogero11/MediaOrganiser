using Newtonsoft.Json;
using System.Collections.Generic;

namespace MediaOrganiser.Modals
{
    public class PlayList
    {
        public PlayList()
        {

        }

        public PlayList(string name, List<MediaFile> mediaFiles)
        {
            Name = name;
            MediaFiles = mediaFiles;
        }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("mediaFiles")]
        public List<MediaFile> MediaFiles { get; set; }
    }
}
