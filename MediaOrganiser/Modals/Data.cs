using Newtonsoft.Json;
using System.Collections.Generic;

namespace MediaOrganiser.Modals
{
    public class Data
    {
        public Data()
        {
            
        }
        
        public Data(List<PlayList> playlists)
        {
            PlayLists = playlists;
        }
        
        [JsonProperty("PlayLists")]
        public List<PlayList> PlayLists { get; set; }
    }
}
