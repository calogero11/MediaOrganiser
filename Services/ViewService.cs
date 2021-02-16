using MediaOrganiser.Interfaces;
using System.Windows.Forms;
using MediaOrganiser.Modals;
using System.Collections.Generic;

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
                fileManger.Items.Add("...", 1);
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
    }
}
