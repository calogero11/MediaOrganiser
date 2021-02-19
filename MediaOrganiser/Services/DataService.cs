using MediaOrganiser.Interfaces;
using MediaOrganiser.Modals;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MediaOrganiser.Services
{
    public class DataService : IDataService
    {
        public bool UpdatePlayList(PlayList fromPlayList, PlayList toPlayList)
        {
            if (fromPlayList.Name == toPlayList.Name)
            {
                return UpdateMediaFile(fromPlayList, toPlayList);
            }
            else
            {
                return MoveAndUpdateMediaFile(fromPlayList, toPlayList);
            }
        }

        private bool UpdateMediaFile(PlayList fromPlayList, PlayList toPlayList)
        {
            var data = ReadData();

            var oldMediaFile = data
               .PlayLists?
               .FirstOrDefault(playList => playList.Name == fromPlayList.Name)?
               .MediaFiles?
               .FirstOrDefault(mediaFile => mediaFile.Name == fromPlayList.MediaFiles.First().Name);

            var updatedMediaFile = toPlayList?
                .MediaFiles?
                .First();

            if (oldMediaFile != null && updatedMediaFile != null)
            {
                oldMediaFile.Name = updatedMediaFile.Name;
                oldMediaFile.Image = updatedMediaFile.Image;
                oldMediaFile.Comment = updatedMediaFile.Comment;
                oldMediaFile.Path = updatedMediaFile.Path;
                oldMediaFile.Categories = updatedMediaFile.Categories;
                SaveChanges(data);

                return true;
            }

            return false;
        }

        private bool MoveAndUpdateMediaFile(PlayList fromPlayList, PlayList toPlayList)
        {
            var data = ReadData();

            var allMediaFilesInPlayList = data
               .PlayLists?
               .FirstOrDefault(playList => playList.Name == fromPlayList.Name)?
               .MediaFiles;

            var oldMediaFile = data
               .PlayLists?
               .FirstOrDefault(playList => playList.Name == fromPlayList.Name)?
               .MediaFiles?
               .FirstOrDefault(mediaFile => mediaFile.Name == fromPlayList.MediaFiles.First().Name);

            if (oldMediaFile != null && toPlayList != null)
            {
                allMediaFilesInPlayList.Remove(oldMediaFile);
                SaveChanges(data);

                PostFiles(toPlayList.Name,
                    toPlayList.MediaFiles.First().Categories.First().Name,
                    toPlayList.MediaFiles.First().Name,
                    toPlayList.MediaFiles.First().Image,
                    toPlayList.MediaFiles.First().Comment);

                return true;
            }


            return false;
        }


        public string GetFilePath(string selectedItem, CurrentDirectory currentDirectory)
        {
            var data = ReadData();

            return data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == currentDirectory.PlayList)?
                .MediaFiles?
                .FirstOrDefault(mediaFile => mediaFile.Name == selectedItem)?
                .Path;
        }

        public Image GetFileImage(string selectedItem, CurrentDirectory currentDirectory)
        {
            var data = ReadData();

            return data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == currentDirectory.PlayList)?
                .MediaFiles?
                .FirstOrDefault(mediaFile => mediaFile.Name == selectedItem)?
                .Image;
        }

        public string GetFileComment(string selectedItem, CurrentDirectory currentDirectory)
        {
            var data = ReadData();

            return data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == currentDirectory.PlayList)?
                .MediaFiles?
                .FirstOrDefault(mediaFile => mediaFile.Name == selectedItem)?
                .Comment;
        }

        public bool UpdateItemIndependently(string selectedItem, string newItemName, CurrentDirectory currentDirectory)
        {
            if (newItemName != null && selectedItem != null)
            {
                switch (currentDirectory)
                {
                    case var x when x.Category != null:
                        break;
                    case var x when x.PlayList != null:
                        return UpdateCategory(selectedItem, newItemName, currentDirectory.PlayList);
                    default:
                        return UpdatePlayList(selectedItem, newItemName);
                }
            }

            return false;
        }

        private bool UpdateCategory(string fromCatergoryName, string toCatergoryName, string playListName)
        {
            var data = ReadData();

            var categories = data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == playListName)?
                .MediaFiles?
                .SelectMany(mediaFile => mediaFile.Categories)?
                .Where(category => category.Name == fromCatergoryName);

            if (categories != null)
            {
                foreach(var mediaFileCategory in categories)
                {
                    mediaFileCategory.Name = toCatergoryName;
                }

                SaveChanges(data);
                return true;
            }

            return false;
        }

        private bool UpdatePlayList(string fromPlayListName, string toPlayListName)
        {
            var data = ReadData();

            if (data.PlayLists?.FirstOrDefault(playList => playList.Name == fromPlayListName) != null)
            {
                data.PlayLists.FirstOrDefault(playList => playList.Name == fromPlayListName).Name = toPlayListName;
                SaveChanges(data);
                return true;
            }

            return false;
        }

        public bool RemoveItemIndependently(string itemName, CurrentDirectory currentDirectory)
        {

            if (itemName != null)
            {
                switch (currentDirectory)
                {
                    case var x when x.Category != null:
                        break;
                    case var x when x.PlayList != null:
                        return RemoveCategory(itemName, currentDirectory.PlayList);
                    default:
                        return RemovePlayList(itemName);
                }
            }

            return false;
        }

        private bool RemoveCategory(string itemName, string playListName)
        {
            var data = ReadData();

            var mediaFiles = data
              .PlayLists?
              .FirstOrDefault(playList => playList.Name == playListName)?
              .MediaFiles;

            if (mediaFiles != null)
            {
                foreach(var mediaFile in mediaFiles)
                {
                    var selectedCategory = mediaFile.Categories.Find(category => category.Name == itemName);

                    if (selectedCategory != null)
                    {
                        mediaFile.Categories.Remove(selectedCategory);
                        SaveChanges(data);
                        return true;
                    }
                }
            }
            return false;
        }

        private bool RemovePlayList(string itemName)
        {
            var data = ReadData();
            
            var selectedPlayList = data.PlayLists?.FirstOrDefault(playList => playList.Name == itemName);
            if (selectedPlayList != null)
            {
                data.PlayLists.Remove(selectedPlayList);
                SaveChanges(data);
                return true;
            }

            return false; 
        }

        public bool PostItemIndependently(string itemName, CurrentDirectory currentDirectory)
        {
            if (currentDirectory != null)
            {
                switch (currentDirectory)
                {
                    case var x when x.Category != null:
                        break;
                    case var x when x.PlayList != null:
                        break;
                    default:
                        return AddPlayList(itemName);
                }
            }

            return false;
        }

        private bool AddPlayList(string playListName)
        {
            var data = ReadData();
            bool isSaved;

            if (playListName != null)
            {
                if (data.PlayLists == null)
                {
                    data.PlayLists = new List<PlayList>
                    {
                        new PlayList(playListName, null)
                    };
                    SaveChanges(data);
                    isSaved = true;
                }
                else
                {
                    data.PlayLists.Add(new PlayList(playListName, null));
                    SaveChanges(data);
                    isSaved = true;
                }
            }
            else
            {
                isSaved = false;
            }
            
            return isSaved;
        }

        private void SaveChanges(Data data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(@"..\..\Data\data.json", json);
        }

        public bool PostFiles(string playListName, string categoryName, string mediaFile, Image image, string comment)
        {
            var data = ReadData();

            var fileInfo = new FileInfo(mediaFile);

            var playLists = data.PlayLists; 
            if (playLists == null)
            {
                data.PlayLists =
                    new List<PlayList> {
                        new PlayList(
                            playListName,
                            new List<MediaFile>
                            {
                                new MediaFile(
                                    fileInfo.Name,
                                    fileInfo.DirectoryName,
                                    fileInfo.Extension,
                                    comment,
                                    image,
                                    new List<Category>
                                    {
                                        new Category(categoryName)
                                    }
                                )
                            }
                        )
                    };
            }
            else if (playLists.Select(playList => playList.Name).Contains(playListName))
            {
                var isFileDuplicate = FileExists(playListName, mediaFile);
              
                if (isFileDuplicate)
                {
                        return false;   
                }

            playLists
            .FirstOrDefault(playList => playList.Name == playListName)
            .MediaFiles
            .Add(
                new MediaFile(
                    fileInfo.Name,
                    fileInfo.DirectoryName,
                    fileInfo.Extension,
                    comment,
                    image,
                    new List<Category>
                    {
                        new Category(categoryName)
                    }
                )
            );

            }
            else
            {
                data.PlayLists.Add(
                    new PlayList(
                        playListName,
                        new List<MediaFile> 
                        {
                            new MediaFile(
                                fileInfo.Name,
                                fileInfo.DirectoryName,
                                fileInfo.Extension,
                                comment,
                                image,
                                new List<Category>
                                {
                                    new Category(categoryName)
                                }
                            ) 
                        }
                    )
                );
            }

            SaveChanges(data);

            return true;
        }

        private bool FileExists(string playListName, string mediaFileName)
        {
            var data = ReadData();

            var playListMediaFileNames = data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == playListName)?
                .MediaFiles?
                .Select(mediaFiles => mediaFiles.Name);

            if (playListMediaFileNames != null && playListMediaFileNames.Contains(mediaFileName))
            {
                return true;
            }

            return false;
        }

        public HashSet<string> GetAllChildren(ListViewItem selectedItem, CurrentDirectory currentDirecotory)
        {
            HashSet<string> items;

            if (currentDirecotory != null)
            {
                switch (currentDirecotory)
                {
                    case var x when x.Category != null:
                        if (selectedItem != null)
                        {
                            if (selectedItem.Tag == "backButton")
                            {
                                items = GetCategories(currentDirecotory.PlayList);
                                currentDirecotory.Category = null;
                            }
                            else
                            {
                                items = GetFiles(currentDirecotory.PlayList, currentDirecotory.Category);
                                if (items != null)
                                {
                                    OpenFile(currentDirecotory, selectedItem.Text);    
                                }
                            }

                            return items;
                        }
                      
                        return null;
                    case var x when x.PlayList != null:
                        if (selectedItem != null)
                        {
                            if (selectedItem.Tag == "backButton")
                            {
                                items = GetPlayLists();
                                currentDirecotory.PlayList = null;
                            }
                            else
                            {
                                items = GetFiles(currentDirecotory.PlayList, selectedItem.Text);
                                currentDirecotory.Category = selectedItem.Text;
                            }

                            return items;
                        }

                        return null;
                    default:
                        if (selectedItem != null)
                        {
                            items = GetCategories(selectedItem.Text);
                            currentDirecotory.PlayList = selectedItem.Text;
                        }
                        else
                        {
                            items = GetPlayLists();
                            currentDirecotory.PlayList = null;
                        }

                        return items;
                }
            }

            return null;
        }

        private void OpenFile(CurrentDirectory currentDirectory, string selectedItem)
        {
            var data = ReadData();
            
            var selectedMediaFile = data
                .PlayLists
                .FirstOrDefault(x => x.Name == currentDirectory.PlayList)
                ?.MediaFiles
                .FirstOrDefault(MediaFile => MediaFile.Categories.Select(category => category.Name).Contains(currentDirectory.Category) &&
                MediaFile.Name == selectedItem);

            Process.Start($"{selectedMediaFile.Path}\\{selectedMediaFile.Name}");
        }

        private HashSet<string> GetFiles(string playListName, string selectedItem)
        {
            var data = ReadData();
            var items = new List<string>();

            var mediaFiles = data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == playListName)?
                .MediaFiles;

            if (mediaFiles != null)
            {
                foreach (var mediaFile in mediaFiles)
                {
                    if ((mediaFile.Categories == null || mediaFile.Categories.Count == 0) && selectedItem == "Unknown")
                    {
                        items.Add(mediaFile.Name);
                    }
                    else if (mediaFile.Categories != null && mediaFile.Categories.Select(category => category.Name).Contains(selectedItem))
                    {
                        items.Add(mediaFile.Name);
                    }
                }

                return new HashSet<string>(items);
            }

            return null;
        }

        private HashSet<string> GetCategories(string selectedItem)
        {
            var data = ReadData();
            var items = new List<string>();

            var mediaFiles = data
                .PlayLists?
                .FirstOrDefault(playList => playList.Name == selectedItem)?
                .MediaFiles;

            if (mediaFiles != null)
            {
                foreach (var mediaFile in mediaFiles)
                {
                    if (mediaFile.Categories == null || mediaFile.Categories.Count == 0)
                    {
                        items.Add("Unknown");
                    }
                    else
                    {
                        items.AddRange(mediaFile.Categories.Select(x => x.Name));
                    }
                }
                
                return new HashSet<string>(items);
            }

            return null;
        }

        private HashSet<string> GetPlayLists()
        {
            var data = ReadData();

            var items = new List<string>();
            if (data.PlayLists != null)
            {
                items.AddRange(
                data
                .PlayLists?
                .Select(PlayList => PlayList.Name));
                
                return new HashSet<string>(items);
            }

            return null;
        }

        private Data ReadData()
        {
            var jsonData = JObject.Parse(File.ReadAllText(@"..\..\Data\data.json") ?? "{}");
            return jsonData?.ToObject<Data>();
        }
    }
}
