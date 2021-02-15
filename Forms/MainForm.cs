using System.Windows.Forms;
using MediaOrganiser.Interfaces;

namespace MediaOrganiser
{
    public partial class MainForm : Form
    {
        public readonly IViewService viewService;


        public MainForm(IViewService viewService)
        {
            this.viewService = viewService;
            InitializeComponent();
            viewService.updateView(LblTitle, new HomeForm(), PnlFormLoader);
        }

        private void BtnHome_Click(object sender, System.EventArgs e)
        {
            viewService.updateView(LblTitle, new HomeForm(), PnlFormLoader);
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}