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
        public void UpdateView(Label title, Form form, Panel pnlFormLoader)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;

            title.Text = form.Name.Substring(0, form.Name.Length - 4);

            pnlFormLoader.Controls.Clear();
            pnlFormLoader.Controls.Add(form);

            form.Show();
        }

        public void ShowFilesAndDirectories(HashSet<string> items, ListView fileManger, CurrentDirectory currentDirectory)
        {
            fileManger.Items.Clear();
            if (currentDirectory.PlayList != null)
            {
                var backFolderItem = new ListViewItem()
                {
                    Text = "...",
                    ImageIndex = 1,
                    Tag = "backButton"
                };
                fileManger.Items.Add(backFolderItem);
            }

            foreach (var item in items)
            {
                if (currentDirectory.PlayList != null && currentDirectory.Category != null)
                {
                    fileManger.Items.Add(item, 0);
                }
                else 
                {
                    fileManger.Items.Add(item, 1);
                }
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
            fromActiveButton.BackColor = Color.FromArgb(221, 221, 221);
            fromActivePanel.BackColor = Color.FromArgb(196, 196, 196);
            toActiveButton.BackColor = Color.FromArgb(240, 240, 240);
            toActivePanel.BackColor = Color.FromArgb(58, 211, 0);

            return (toActiveButton, toActivePanel);
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
