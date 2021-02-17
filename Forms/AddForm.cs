using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Modals;

namespace MediaOrganiser
{
    public partial class AddForm : Form
    {
        private readonly IDataService dataService;
        private readonly IViewService viewService;
        public Image selectedImage = new Image();
        public string selectedMediaFile;

        public AddForm(IDataService dataService, IViewService viewService)
        {
            this.dataService = dataService;
            this.viewService = viewService;
            InitializeComponent();
            
            var hashSetPlayLists = this.dataService.GetPlayLists();
            string[] arrayPlayLists = new string[hashSetPlayLists.Count];
            hashSetPlayLists.CopyTo(arrayPlayLists);

            this.viewService.AddTextBoxAutoComplete(TxtbxPlayList, arrayPlayLists);
        }

        private void TxtbxPlayList_TextChanged(object sender, EventArgs e)
        {
            var hashSetPlayLists = this.dataService.GetPlayLists();
            if (hashSetPlayLists.Contains(TxtbxPlayList.Text))
            {
                var hashSetCategories = this.dataService.GetAllChildren(TxtbxPlayList.Text, new CurrentDirectory());
                string[] arrayCategories = new string[hashSetCategories.Count];
                hashSetCategories.CopyTo(arrayCategories);

                viewService.AddTextBoxAutoComplete(TxtbxCategory, arrayCategories);
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
                    selectedMediaFile = openFileDialog.FileName;
                    TxtbxMediaFile.Text = openFileDialog.SafeFileName;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var successfulPost = dataService.PostFiles(TxtbxPlayList.Text, TxtbxCategory.Text, selectedMediaFile, selectedImage, TxtbxComment.Text);

            if (successfulPost)
            {
                LblOutcome.Text = "File added successfully";
                viewService.ClearForm(new List<TextBox> { TxtbxPlayList, TxtbxCategory, TxtbxImage, TxtbxMediaFile, TxtbxComment });
            }
            else
            {
                LblOutcome.Text = "Error - File already exists or invalid";
            }
        }
    }
}