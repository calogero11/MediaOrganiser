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


            viewService.SetUpFormLoader(LblTitle, PnlFormLoader);

            if (dataService.GetAllChildren(null, new CurrentDirectory()) == null)
            {
                viewService.UpdateView(new EmptyHomeForm());
            }
            else
            {
                viewService.UpdateView(new HomeForm(viewService, dataService));
            }

            activeMenuButton = (BtnHome, PnlHomeButtonIndicator);
        }

        private void BtnHome_Click(object sender, System.EventArgs e)
        {
            var activateButtonResult = viewService.ActivateButton(activeMenuButton.Item1, activeMenuButton.Item2, BtnHome, PnlHomeButtonIndicator);
            if (activateButtonResult.Item1 != null || activateButtonResult.Item2 != null)
            {
                activeMenuButton = activateButtonResult;
            }
          
            if (dataService.GetAllChildren(null, new CurrentDirectory()) == null)
            {
                viewService.UpdateView(new EmptyHomeForm());
            }
            else
            {
                viewService.UpdateView(new HomeForm(viewService, dataService));
            }
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            var activateButtonResult = viewService.ActivateButton(activeMenuButton.Item1, activeMenuButton.Item2, BtnExit, PnlExitButtonIndicator);
            if (activateButtonResult.Item1 != null || activateButtonResult.Item2 != null)
            {
                activeMenuButton = activateButtonResult;
            }
            Application.Exit();
        }

        private void BtnAdd_MouseEnter(object sender, System.EventArgs e)
        {
            TtMainMenu.Show("Add media with info", BtnAdd);
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            var activateButtonResult = viewService.ActivateButton(activeMenuButton.Item1, activeMenuButton.Item2, BtnAdd, PnlAddButtonIndicator);
            if (activateButtonResult.Item1 != null || activateButtonResult.Item2 != null)
            {
                activeMenuButton = activateButtonResult;
            }

            viewService.UpdateView(new AddForm(dataService, viewService));
        }
    }
}