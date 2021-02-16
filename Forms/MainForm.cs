using System.Windows.Forms;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Services;

namespace MediaOrganiser
{
    public partial class MainForm : Form
    {
        public readonly IViewService viewService;
        public readonly IDataService dataService;

        public MainForm(IViewService viewService, IDataService dataService)
        {
            this.viewService = viewService;
            this.dataService = dataService;

            InitializeComponent();

            var playlists = dataService.GetPlayLists();
            
            if (playlists == null)
            {
                viewService.UpdateView(LblTitle, new EmptyHomeForm(), PnlFormLoader);
            }
            else
            {
                viewService.UpdateView(LblTitle, new HomeForm((IViewService) new ViewService(), (IDataService)new DataService()), PnlFormLoader);
            }
        }

        private void BtnHome_Click(object sender, System.EventArgs e)
        {
            var playlists = dataService.GetPlayLists();

            if (playlists == null)
            {
                viewService.UpdateView(LblTitle, new EmptyHomeForm(), PnlFormLoader);
            }
            else
            {
                viewService.UpdateView(LblTitle, new HomeForm((IViewService)new ViewService(), (IDataService)new DataService()), PnlFormLoader);
            }
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}