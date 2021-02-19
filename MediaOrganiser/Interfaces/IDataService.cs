using MediaOrganiser.Modals;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaOrganiser.Interfaces
{
    public interface IDataService
    {
        string GetFilePath(string selectedItem, CurrentDirectory currentDirectory);
        Image GetFileImage(string selectedItem, CurrentDirectory currentDirectory);
        string[] GetAllCategories(string selectedItem, CurrentDirectory currentDirectory);
        string GetFileComment(string selectedItem, CurrentDirectory currentDirectory);
        HashSet<string> GetAllChildren(ListViewItem selectedItem, CurrentDirectory currentDirecotory);
        bool PostFiles(string playListName, string[] categoryName, string mediaFile, Image image, string comment);
        bool PostItemIndependently(string itemName, CurrentDirectory currentDirectory);
        bool RemoveItemIndependently(string itemName, CurrentDirectory currentDirectory);
        bool UpdateItemIndependently(string selectedItem, string newItemName, CurrentDirectory currentDirectory);
        bool UpdatePlayList(PlayList fromPlayList, PlayList toPlayList);
    }
}
