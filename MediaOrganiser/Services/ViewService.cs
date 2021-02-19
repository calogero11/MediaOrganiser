using MediaOrganiser.Interfaces;
using System.Windows.Forms;
using MediaOrganiser.Modals;
using System.Collections.Generic;
using System.Drawing;
using Image = System.Drawing.Image;

namespace MediaOrganiser.Services
{
    class ViewService: IViewService
    {
        public static Label MainMenuTitle { get; set; }
        public static Panel FormLoader { get; set; }

        public void SetUpFormLoader(Label title, Panel formLoader)
        {
            MainMenuTitle = title;
            FormLoader = formLoader;
        }

        public void UpdateView(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;

            MainMenuTitle.Text = form.Name.Substring(0, form.Name.Length - 4);

            FormLoader.Controls.Clear();
            FormLoader.Controls.Add(form);

            form.Show();
        }

        public void ShowFilesAndDirectories(List<Item> items, ListView fileManger, CurrentDirectory currentDirectory, ImageList imageList)
        {
            ResetImageList(imageList);
            fileManger.Items.Clear();
            if (currentDirectory?.PlayList != null)
            {
                var backFolderItem = new ListViewItem()
                {
                    Text = "...",
                    ImageIndex = 1,
                    Tag = "backButton",
                    ToolTipText = "back"
                };
                fileManger.Items.Add(backFolderItem);
            }

            if (items != null)
            {
                foreach (var item in items)
                {
                    if (currentDirectory.PlayList != null && currentDirectory.Category != null)
                    {
                        var listViewItem = new ListViewItem()
                        {
                            Text = item.Name,
                            ToolTipText = item.Comment
                        };

                        if (item.Image.Path != null)
                        {
                            var image = Image.FromFile(item.Image.Path);
                            imageList.Images.Add(image);
                            listViewItem.ImageIndex = imageList.Images.Count - 1;

                        }
                        else
                        {
                            listViewItem.ImageIndex = 0;
                        }

                        fileManger.Items.Add(listViewItem);
                    }
                    else
                    {
                        fileManger.Items.Add(item.Name, 1);
                    }
                }
            }
        }

        public void ResetImageList(ImageList imageList)
        {
            imageList.Images.Clear();
            var defaultFile = Image.FromFile(@"..\..\Assets\Images\file.png");
            var defaultFolder = Image.FromFile(@"..\..\Assets\Images\folder.png");
            var images = new List<Image> { defaultFile, defaultFolder};
            foreach (var image in images)
            {
                imageList.Images.Add(image);
            }
        }

        public void AddTextBoxAutoComplete(TextBox textBox, string[] suggestions)
        {
            if (suggestions != null)
            {
                var autoCompleteStringCollection = new AutoCompleteStringCollection();
                autoCompleteStringCollection.AddRange(suggestions);
                textBox.AutoCompleteCustomSource = autoCompleteStringCollection;
            }   
        }

        public (Button, Panel) ActivateButton(Button fromActiveButton, Panel fromActivePanel, Button toActiveButton, Panel toActivePanel)
        {
            if (fromActiveButton != null && fromActivePanel != null && toActiveButton != null && toActivePanel != null)
            {
                var ActiveButtonColor = fromActiveButton.BackColor;
                var ActivePanelColor = fromActivePanel.BackColor;

                fromActiveButton.BackColor = Color.FromArgb(221, 221, 221);
                fromActivePanel.BackColor = Color.FromArgb(196, 196, 196);
                toActiveButton.BackColor = ActiveButtonColor;
                toActivePanel.BackColor = ActivePanelColor;
              
            
                return (toActiveButton, toActivePanel);
            }
            
            return (null, null);
        }

        public void ClearForm(List<TextBox> textBoxes)
        {
            foreach(var textBox in textBoxes)
            {
                textBox.Text = null;
            }
        }
    }
}
