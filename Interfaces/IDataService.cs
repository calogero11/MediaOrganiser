﻿using MediaOrganiser.Modals;
using System.Collections.Generic;

namespace MediaOrganiser.Interfaces
{
    public interface IDataService
    {
        HashSet<string> GetPlayLists();
        HashSet<string> GetAllChildren(string selectedItem, CurrentDirectory currentDirecotory);
        bool PostFiles(string playListName, string categoryName, string mediaFile, Image image, string comment);
    }
}
