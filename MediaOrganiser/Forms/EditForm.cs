using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Modals;

namespace MediaOrganiser
{
    public partial class EditForm : Form
    {
        private readonly IDataService dataService;
        private readonly IViewService viewService;
        private Image selectedImage = new Image();
        private string selectedMediaFilePath;
        private CurrentDirectory currentDirectory;
        private PlayList fromPlayList;

        public EditForm(IDataService dataService, IViewService viewService, string selectedMediaFile, CurrentDirectory currentDirectory)
        {
            this.dataService = dataService;
            this.viewService = viewService;
            this.currentDirectory = currentDirectory;
            this.selectedMediaFilePath = dataService.GetFilePath(selectedMediaFile, currentDirectory);
            InitializeComponent();

            selectedImage = dataService.GetFileImage(selectedMediaFile, currentDirectory);
            SetFormInfo(selectedMediaFile);
            fromPlayList = SetCurrentPlayListInfo(selectedMediaFile);
            
            var hashSetPlayLists = this.dataService.GetAllChildren(null, new CurrentDirectory());
            if (hashSetPlayLists != null)
            {
                string[] arrayPlayLists = new string[hashSetPlayLists.Count];
                hashSetPlayLists.CopyTo(arrayPlayLists);
                this.viewService.AddTextBoxAutoComplete(TxtbxPlayList, arrayPlayLists);
            }
        }

        private PlayList SetCurrentPlayListInfo(string selectedMediaFile)
        {
            var category = new Category(currentDirectory.Category);
            var mediaFile = new MediaFile(selectedMediaFile, selectedMediaFilePath, new FileInfo(selectedMediaFilePath).Extension, dataService.GetFileComment(selectedMediaFile, currentDirectory), selectedImage, new List<Category> { category });
            return new PlayList(currentDirectory.PlayList, new List<MediaFile> { mediaFile });
        }

        private void SetFormInfo(string selectedMediaFile)
        {
            TxtbxPlayList.Text = currentDirectory?.PlayList;
            TxtbxCategory.Text = currentDirectory?.Category;
            TxtbxImage.Text = selectedImage?.Name;
            TxtbxMediaFile.Text = selectedMediaFile;
            TxtbxComment.Text = dataService.GetFileComment(selectedMediaFile, currentDirectory);
        }

        private void TxtbxPlayList_TextChanged(object sender, EventArgs e)
        {
            var hashSetPlayLists = dataService.GetAllChildren(null, new CurrentDirectory());
            if (hashSetPlayLists != null && hashSetPlayLists.Contains(TxtbxPlayList.Text))
            {
                var selectedItem = new ListViewItem()
                {
                    Text = TxtbxPlayList.Text
                };
                
                var hashSetCategories = this.dataService.GetAllChildren(selectedItem, new CurrentDirectory());
                if (hashSetCategories != null)
                {
                    string[] arrayCategories = new string[hashSetCategories.Count];
                    hashSetCategories.CopyTo(arrayCategories);

                    viewService.AddTextBoxAutoComplete(TxtbxCategory, arrayCategories);
                }
               
            }
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Public\Pictures";
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImage.Name = openFileDialog.SafeFileName;
                    selectedImage.Path = openFileDialog.FileName;
                    TxtbxImage.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void BtnSelectMediaFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"C:\Users\Public\Videos";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedMediaFilePath = new FileInfo(openFileDialog.FileName).DirectoryName;
                    TxtbxMediaFile.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            var category = new Category(TxtbxCategory.Text);
            var mediaFile = new MediaFile(TxtbxMediaFile.Text, selectedMediaFilePath, new FileInfo(selectedMediaFilePath).Extension, TxtbxComment.Text, selectedImage, new List<Category> { category });
            var toPlayList = new PlayList(TxtbxPlayList.Text, new List<MediaFile> { mediaFile });
            var successfulUpdate = dataService.UpdatePlayList(fromPlayList, toPlayList);
            

            if (successfulUpdate)
            {
                LblOutcome.Text = "File updated successfully";
                viewService.UpdateView(new HomeForm(viewService, dataService, new CurrentDirectory(toPlayList.Name), new ListViewItem() { Text = toPlayList.MediaFiles.First().Categories.First().Name } ));
            }
            else
            {
                LblOutcome.Text = "Error - File already exists or invalid";
            }
        }

        private void BtnRemoveImage_Click(object sender, EventArgs e)
        {
            TxtbxImage.Text = " ";
            selectedImage = new Image();
        }
    }
}