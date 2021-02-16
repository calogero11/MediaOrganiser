using System.Windows.Forms;
using System.Collections.Generic;
using MediaOrganiser.Modals;

namespace MediaOrganiser.Interfaces
{
    public interface IViewService
    {
        void UpdateView(Label title, Form form, Panel pnlFormLoader);
        void ShowFilesAndDirectories(HashSet<string> items, ListView fileManager, CurrentDirectory currentDirectory);
    }
}
