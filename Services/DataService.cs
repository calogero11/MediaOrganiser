using MediaOrganiser.Interfaces;
using MediaOrganiser.Modals;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace MediaOrganiser.Services
{
    public class DataService: IDataService
    {
        public HashSet<string> GetAllChildren(string selectedItem, CurrentDirectory currentDirecotory)
        {
            var data = ReadData();
            var items = new HashSet<string>();

            switch (currentDirecotory)
            {
                case var x when x.Category != null:
                    if (selectedItem == "...")
                    {
                        items = GetCategories(data, currentDirecotory.PlayList);
                        currentDirecotory.Category = null;
                        return items;
                    }

                    items = GetFiles(data, currentDirecotory.PlayList, currentDirecotory.Category);
                    OpenFile(data, currentDirecotory, selectedItem);
                    return items;
                case var x when x.PlayList != null:
                    if (selectedItem != "...")
                    {
                        items = GetFiles(data, currentDirecotory.PlayList, selectedItem);
                        currentDirecotory.Category = selectedItem;
                        return items;
                    }

                    items = GetPlayLists();
                    currentDirecotory.PlayList = null;
                    return items;
                default:
                    if (selectedItem != "...")
                    {
                        items = GetCategories(data, selectedItem);
                        currentDirecotory.PlayList = selectedItem;
                        return items;
                    }

                    items = GetPlayLists();
                    currentDirecotory.PlayList = null;
                    return items;
            }
        }

        private void OpenFile(Data data, CurrentDirectory currentDirectory, string selectedItem)
        {
            var selectedMediaFile = data
                .PlayLists
                .FirstOrDefault(x => x.Name == currentDirectory.PlayList)
                .MediaFiles
                .FirstOrDefault(MediaFile => MediaFile.Categories.Select(category => category.Name).Contains(currentDirectory.Category) &&
                MediaFile.Name == selectedItem);

            Process.Start(selectedMediaFile.Path);
        }

        private HashSet<string> GetFiles(Data data, string playListName, string selectedItem)
        {
            var items = new List<string>();

            var mediaFiles = data
                .PlayLists
                .FirstOrDefault(playList => playList.Name == playListName)
                .MediaFiles;


            foreach (var mediaFile in mediaFiles)
            {
                if (mediaFile.Categories.Select(category => category.Name).Contains(selectedItem))
                {
                    items.Add(mediaFile.Name);
                }
            }

            return new HashSet<string>(items);
        }

        private HashSet<string> GetCategories(Data data, string selectedItem)
        {
            var items = new List<string>();

            var mediaFiles = data
                .PlayLists
                .FirstOrDefault(playList => playList.Name == selectedItem).MediaFiles;

            foreach (var mediaFile in mediaFiles)
            {
                items.AddRange(mediaFile.Categories.Select(x => x.Name));
            }

            return new HashSet<string>(items);
        }

        public HashSet<string> GetPlayLists()
        {
            var data = ReadData();

            var items = new List<string>();
            items.AddRange(
                data
                .PlayLists
                .Select(PlayList => PlayList.Name));

            return new HashSet<string>(items);
        }

        private Data ReadData()
        {
            var jsonData = JObject.Parse(File.ReadAllText(@"..\..\Data\data.json") ?? "{}");
            return jsonData?.ToObject<Data>();
        }
    }
}
