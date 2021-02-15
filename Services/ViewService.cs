using MediaOrganiser.Interfaces;
using System.Windows.Forms;

namespace MediaOrganiser.Services
{
    class ViewService: IViewService
    {
        public void updateView(Label title, Form form, Panel pnlFormLoader)
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
    }
}
