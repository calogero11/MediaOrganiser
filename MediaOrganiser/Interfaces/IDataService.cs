using MediaOrganiser.Modals;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaOrganiser.Interfaces
{
    public interface IDataService
    {
        HashSet<string> GetAllChildren(ListViewItem selectedItem, CurrentDirectory currentDirecotory);
        bool PostFiles(string playListName, string categoryName, string mediaFile, Image image, string comment);
        bool PostItemIndependently(string itemName, CurrentDirectory currentDirectory);
        bool RemoveItemIndependently(string itemName, CurrentDirectory currentDirectory);
        bool UpdateItemIndependently(string selectedItem, string newItemName, CurrentDirectory currentDirectory);
    }
}
