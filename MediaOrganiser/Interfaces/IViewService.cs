using System.Windows.Forms;
using System.Collections.Generic;
using MediaOrganiser.Modals;

namespace MediaOrganiser.Interfaces
{
    public interface IViewService
    {
        void SetUpFormLoader(Label title, Panel formLoader);
        void UpdateView(Form form);
        void ShowFilesAndDirectories(HashSet<string> items, ListView fileManager, CurrentDirectory currentDirectory);
        (Button, Panel) ActivateButton(Button fromActiveButton, Panel fromActivePanel, Button toActiveButton, Panel toActivePanel);
        void AddTextBoxAutoComplete(TextBox textBox, string[] suggestions);
        void ClearForm(List<TextBox> textBoxes);
    }
}
