using System.Windows.Forms;

namespace MediaOrganiser.Interfaces
{
    public interface IViewService
    {
        void updateView(Label title, Form form, Panel pnlFormLoader);
    }
}
