using MediaOrganiser.Interfaces;
using System.Windows.Forms;
using MediaOrganiser.Modals;
using System.Collections.Generic;

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
            viewService.ClearForm(new List<TextBox> { TxtbxFileManager });
        }

        private string GetCurrentDirectory()
        {
            if (currentDirectory.Category != null)
            {
                return  currentDirectory.Category;
            }
            else if (currentDirectory.PlayList != null)
            {
                return currentDirectory.PlayList;
            }
            else
            {
                return null;
            }
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you wish to remove this item ??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dataService.RemoveItemIndependently(selectedItem, currentDirectory);
                selectedItem = GetCurrentDirectory();
                var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
                viewService.ShowFilesAndDirectories(storedItems, FileManager, currentDirectory);
            }
           
        }
    }
}