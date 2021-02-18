using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaOrganiser.Modals
{
    public class CurrentDirectory
    {
        public CurrentDirectory()
        {
            
        }

        public CurrentDirectory(string playList)
        {
            PlayList = playList;
        }

        public CurrentDirectory(string playList, string category)
        {
            PlayList = playList;
            Category = category;
        }

        public string PlayList { get; set; }
        public string Category { get; set; }
    }
}
