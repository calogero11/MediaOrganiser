using System.Windows.Forms;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Modals;
using MediaOrganiser.Services;

namespace MediaOrganiser
{
    public partial class MainForm : Form
    {
        private readonly IViewService viewService;
        private readonly IDataService dataService;
        private (Button, Panel) activeMenuButton;

        public MainForm(IViewService viewService, IDataService dataService)
        {
            this.viewService = viewService;
            this.dataService = dataService;

            InitializeComponent();

            if (dataService.GetAllChildren(null, new CurrentDirectory()) == null)
            {
                viewService.UpdateView(LblTitle, new EmptyHomeForm(), PnlFormLoader);
            }
            else
            {
                viewService.UpdateView(LblTitle, new HomeForm(viewService, dataService), PnlFormLoader);
            }

            activeMenuButton = (BtnHome, PnlHomeButtonIndicator);
        }

        private void BtnHome_Click(object sender, System.EventArgs e)
        {
            activeMenuButton = viewService.ActivateButton(activeMenuButton.Item1, activeMenuButton.Item2, BtnHome, PnlHomeButtonIndicator);
          
            if (dataService.GetAllChildren(null, new CurrentDirectory()) == null)
            {
                viewService.UpdateView(LblTitle, new EmptyHomeForm(), PnlFormLoader);
            }
            else
            {
                viewService.UpdateView(LblTitle, new HomeForm(viewService, dataService), PnlFormLoader);
            }
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            activeMenuButton = viewService.ActivateButton(activeMenuButton.Item1, activeMenuButton.Item2, BtnExit, PnlExitButtonIndicator);
            Application.Exit();
        }

        private void BtnAdd_MouseEnter(object sender, System.EventArgs e)
        {
            TtMainMenu.Show("Add media with info", BtnAdd);
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            activeMenuButton = viewService.ActivateButton(activeMenuButton.Item1, activeMenuButton.Item2, BtnAdd, PnlAddButtonIndicator);
            viewService.UpdateView(LblTitle, new AddForm(dataService, viewService), PnlFormLoader);
        }
    }
}