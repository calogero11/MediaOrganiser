using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaOrganiser.Modals
{
    public class Item
    {
        public Item(string name, Image image, string comment)
        {
            Name = name;
            Image = image;
            Comment = comment;
        }

        public Item(string name) 
        {
            Name = name;
        }

        public string Name { get; set; }
        public Image Image { get; set; }
        public string Comment { get; set; }
    }
}
