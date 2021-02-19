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
        private ListViewItem selectedItem { get; set; }
        private CurrentDirectory currentDirectory = new CurrentDirectory();

        public HomeForm(IViewService viewService,
            IDataService dataService,
            CurrentDirectory currentDirectory = null,
            ListViewItem selectedItem = null)
        { 
            this.viewService = viewService;
            this.dataService = dataService;
            if (currentDirectory != null)
            {
                this.currentDirectory = currentDirectory;
            }
            if (selectedItem != null)
            {
                this.selectedItem = selectedItem;
            }
          
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, System.EventArgs e)
        {
            var playLists = dataService.GetAllChildren(selectedItem, currentDirectory);
            var itemList = GetItemList(playLists);
            viewService.ShowFilesAndDirectories(itemList, FileManager, currentDirectory, iconList);

            SetCurrentDirectory();
        }

        private void FileManager_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            var itemList = GetItemList(storedItems);
            viewService.ShowFilesAndDirectories(itemList, FileManager, currentDirectory, iconList);

            SetCurrentDirectory();
        }

        private void SetCurrentDirectory()
        {
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
            PostItem();
            viewService.ClearForm(new List<TextBox> { TxtbxFileManager });
        }

        private void PostItem()
        {
            dataService.PostItemIndependently(TxtbxFileManager.Text, currentDirectory);
            RefreshFileManager();
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
                dataService.RemoveItemIndependently(selectedItem?.Text, currentDirectory);
                RefreshFileManager();
            }
        }

        private void RefreshFileManager()
        {
            var items = new List<Item>();
            selectedItem = GetCurrentDirectory();
            var storedItems = dataService.GetAllChildren(selectedItem, currentDirectory);
            var itemList = GetItemList(storedItems);

            viewService.ShowFilesAndDirectories(itemList, FileManager, currentDirectory, iconList);
        }

        private List<Item> GetItemList(HashSet<string> storedItems)
        {
            if (storedItems != null)
            {
                var items = new List<Item>();

                if (currentDirectory.PlayList != null && currentDirectory.Category != null)
                {
                    foreach (var storedItem in storedItems)
                    {
                        var comment = dataService.GetFileComment(storedItem, currentDirectory);
                        var image = dataService.GetFileImage(storedItem, currentDirectory);
                        items.Add(new Item(storedItem, image, comment));
                    }
                }
                else
                {
                    foreach (var storedItem in storedItems)
                    {
                        items.Add(new Item(storedItem));
                    }
                }



                return items;
            }

            return null;
        }

        private void BtnEdit_Click(object sender, System.EventArgs e)
        {
            if (currentDirectory.Category != null)
            {
                viewService.UpdateView(new EditForm(dataService, viewService, selectedItem.Text, currentDirectory));
            }

            dataService.UpdateItemIndependently(selectedItem.Text, TxtbxFileManager.Text, currentDirectory);
            RefreshFileManager();
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