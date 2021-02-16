using MediaOrganiser.Interfaces;
using System.Windows.Forms;
using MediaOrganiser.Modals;
using System.Linq;

namespace MediaOrganiser
{
    public partial class HomeForm : Form
    {
        private readonly IViewService viewService;
        private readonly IDataService dataService;
        public string selectedItem;
        public CurrentDirectory currentDirectory = new CurrentDirectory();

        public HomeForm(IViewService viewService, 
            IDataService dataService)
        {
            this.viewService = viewService;
            this.dataService = dataService;
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            var playLists = dataService.GetPlayLists();
            viewService.ShowFilesAndDirectories(playLists, FileManger, currentDirectory);
        }

        private void FileManger_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // check if the selected file is a dir
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            viewService.ShowFilesAndDirectories(storedItems, FileManger, currentDirectory);
        }

        private void FileManger_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
        }
    }
}