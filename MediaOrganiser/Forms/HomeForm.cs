using MediaOrganiser.Interfaces;
using System.Windows.Forms;
using MediaOrganiser.Modals;
using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;

namespace MediaOrganiser
{
    public partial class HomeForm : Form
    {
        private readonly IViewService viewService;
        private readonly IDataService dataService;
        private ListViewItem selectedItem { get; set; }
        private CurrentDirectory currentDirectory = new CurrentDirectory();

        public HomeForm(IViewService viewService,
            IDataService dataService)
        {
            this.viewService = viewService;
            this.dataService = dataService;
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            var playLists = dataService.GetAllChildren(null, currentDirectory);
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
            selectedItem = e.Item;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            dataService.PostItemIndependently(TxtbxFileManager.Text, currentDirectory);
            var selectedItem = GetCurrentDirectory();
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            viewService.ShowFilesAndDirectories(storedItems, FileManager, currentDirectory);
            viewService.ClearForm(new List<TextBox> { TxtbxFileManager });
        }

        private ListViewItem GetCurrentDirectory()
        {
            if (currentDirectory.Category != null)
            {
                var currentPosition = currentDirectory.Category;
                currentDirectory.Category = null;
                return new ListViewItem() { Text = currentPosition};
            }
            else if (currentDirectory.PlayList != null)
            {
                var currentPosition = currentDirectory.PlayList;
                currentDirectory.PlayList = null;
                return new ListViewItem() { Text = currentPosition};
            }
            
            return null;
        }

        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            RemoveItem();
        }

        private void RemoveItem()
        {
            var confirmResult = MessageBox.Show("Are you sure you wish to remove this item ??",
                                    "Confirm Delete!!",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                dataService.RemoveItemIndependently(selectedItem.Text, currentDirectory);
                selectedItem = GetCurrentDirectory();
                var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
                viewService.ShowFilesAndDirectories(storedItems, FileManager, currentDirectory);
            }
        }

        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            dataService.UpdateItemIndependently(selectedItem.Text, TxtbxFileManager.Text, currentDirectory);
            selectedItem = GetCurrentDirectory();
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            viewService.ShowFilesAndDirectories(storedItems, FileManager, currentDirectory);
            viewService.ClearForm(new List<TextBox> { TxtbxFileManager });
        }

        private void FileManager_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                RemoveItem();
            }
        }
    }
}