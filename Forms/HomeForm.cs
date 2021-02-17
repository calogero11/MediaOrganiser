using MediaOrganiser.Interfaces;
using System.Windows.Forms;
using MediaOrganiser.Modals;

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
            viewService.ShowFilesAndDirectories(playLists, FileManager, currentDirectory);
        }

        private void FileManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            viewService.ShowFilesAndDirectories(storedItems, FileManager, currentDirectory);

            if (currentDirectory.Category == null && currentDirectory.PlayList != null)
            {
                LblCurrentDirectory.Text = $"Current Directory: {currentDirectory.PlayList}";
            }
            else if (currentDirectory.Category != null && currentDirectory.PlayList != null)
            {
                LblCurrentDirectory.Text = $"Current Directory: {currentDirectory.PlayList} > {currentDirectory.Category}";
            }
            else
            {
                LblCurrentDirectory.Text = "Current Directory: ";
            }
        }

        private void FileManager_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedItem = e.Item.Text;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            dataService.PostItemIndependently(TxtbxFileManager.Text, currentDirectory);
            selectedItem = GetCurrentDirectory();
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            viewService.ShowFilesAndDirectories(storedItems, FileManager, currentDirectory);
        }

        private string GetCurrentDirectory()
        {
            if (currentDirectory.Category != null)
            {
                selectedItem = currentDirectory.Category;
            }
            else if (currentDirectory.PlayList != null)
            {
                selectedItem = currentDirectory.PlayList;
            }
            else
            {
                selectedItem = null;
            }

            return selectedItem;
        }
    }
}