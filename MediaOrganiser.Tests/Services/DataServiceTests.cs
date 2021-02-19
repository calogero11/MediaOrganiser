using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using FakeItEasy;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Modals;
using MediaOrganiser.Services;
using Newtonsoft.Json;
using NUnit.Framework;

namespace MediaOrganiser.Tests.Services
{
    [TestFixture]
    public class DataServiceTests
    {
        private DataService dataService;
        private IViewService viewService;
        
        [SetUp]
        public void Setup()
        {
            dataService = new DataService();
            CreateDataFile();
        }

        private static void CreateDataFile()
        {
            Directory.CreateDirectory(@"..\..\Data");
            var dataFile = File.Create(@"..\..\Data\data.json");
            dataFile.Close();
        }

        private static void SetTestData(Data data)
        {
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText(@"..\..\Data\data.json", json);
        }

        public static IEnumerable<TestCaseData> AllPossibleCurrentDirectoryValues
        {
            get
            {
                return new []
                {
                    new TestCaseData(new CurrentDirectory()),
                    new TestCaseData(new CurrentDirectory("TestItem")),
                    new TestCaseData(new CurrentDirectory("TestItem", "TestItem")), 
                }; 
            }
        }

        #region PostItemIndependentlyTests
        
        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void PostItemIndependently_WhenItemNameIsNull_ReturnFalse(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.PostItemIndependently(null, currentDirectory);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void PostItemIndependently_WhenCurrentDirectoryIsNull_ReturnFalse()
        {
            SetTestData(new Data());
            var result = dataService.PostItemIndependently("TestItem", null);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void PostItemIndependently_WhenCurrentDirectoryIsNullAndItemNameIsNull_ReturnFalse()
        {
            SetTestData(new Data());
            var result = dataService.PostItemIndependently(null, null);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void PostItemIndependently_WhenItemNameAndCurrentDirectoryHasValue_ReturnTrue(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.PostItemIndependently("TestItem", currentDirectory);
            Assert.That(result, Is.EqualTo(true));
        }
        
        #endregion

        #region PostFiles

        public static IEnumerable<TestCaseData> AllPossiblePostFilesRequiredValues
        {
            get
            {
                return new []
                {
                    new TestCaseData("TestPlayList", "TestCategory", "TestMediaFile", new Image("TestImage", "TestImagePath"), "TestComment"),
                    new TestCaseData("TestPlayList", null, "TestMediaFile", new Image("TestImage", "TestImagePath"), "TestComment"),
                    new TestCaseData("TestPlayList", "TestCategory", "TestMediaFile", new Image("TestImage", "TestImagePath"), null),
                    new TestCaseData("TestPlayList", null, "TestMediaFile", null, null),
                    new TestCaseData("TestPlayList", null, "TestMediaFile", null, "TestComment"),
                    new TestCaseData("TestPlayList", null, "TestMediaFile", new Image("TestImage", "TestImagePath"), null),
                    new TestCaseData("TestPlayList", "TestCategory", "TestMediaFile", null, null),
                    new TestCaseData("TestPlayList", null, null, null, null)
                }; 
            }
        }

        public static IEnumerable<TestCaseData> AllPossibleInvalidPostFileValues
        {
            get
            {
                return new[]
                {
                    new TestCaseData("TestPlayList", "TestCategory", null, new Image("TestImage", "TestImagePath"), "TestComment"),
                    new TestCaseData("TestPlayList", "TestCategory", null, null, "TestComment"),
                    new TestCaseData("TestPlayList", "TestCategory", null,  new Image("TestImage", "TestImagePath"), null),
                    new TestCaseData("TestPlayList", "TestCategory", null,  null, null),
                    new TestCaseData("TestPlayList", null, null,  new Image("TestImage", "TestImagePath"), null),
                    new TestCaseData("TestPlayList", null, null,  null, "TestComment"),
                    new TestCaseData(null , "TestCategory", "TestMediaFile", new Image("TestImage", "TestImagePath"), "TestComment"),
                    new TestCaseData(null , "TestCategory", null, new Image("TestImage", "TestImagePath"), "TestComment"),
                    new TestCaseData(null, null, null, null, null), 
                    new TestCaseData(null, "TestCategory", null, null, null),
                    new TestCaseData(null, null, null, new Image("TestImage", "TestImagePath"), null),
                    new TestCaseData(null, null, null, new Image("TestImage", null), null),
                    new TestCaseData(null, null, null, new Image(null, null), null),
                };
            }
        }

        [Test]
        [TestCaseSource("AllPossibleInvalidPostFileValues")]
        public void PostFiles_WhenRequiredDataIsNotPopulated_ReturnFalse(string playListName, string categoryName, string mediaFile, Image image, string comment)
        {
            SetTestData(new Data());
            var result = dataService.PostFiles(playListName, categoryName, mediaFile, image, comment);
            Assert.That(result, Is.EqualTo(false));
        }
        
        [Test]
        [TestCaseSource("AllPossiblePostFilesRequiredValues")]
        public void PostFiles_WhenRequiredDataIsPopulated_ReturnTrue(string playListName, string categoryName, string mediaFile, Image image, string comment)
        {
            SetTestData(new Data());
            var result = dataService.PostFiles(playListName, categoryName, mediaFile, image, comment);
            Assert.That(result, Is.EqualTo(true));
        }

        #endregion

        #region RemoveItemIndependently
        
        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void RemoveItemIndependently_WhenItemNameIsNull_ReturnFalse(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.RemoveItemIndependently(null, currentDirectory);
            Assert.That(result, Is.EqualTo(false));
        }
        
  

        [Test]
        public void RemoveItemIndependently_WhenCurrentDirectoryIsNull_ReturnFalse()
        {
            SetTestData(new Data());
            var result = dataService.RemoveItemIndependently("TestItem", null);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void RemoveItemIndependently_WhenCurrentDirectoryIsNullAndItemNameIsNull_ReturnFalse()
        {
            SetTestData(new Data());
            var result = dataService.RemoveItemIndependently(null, null);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void RemoveItemIndependently_WhenItemNameExistsInCurrentDirectory_ReturnTrue(CurrentDirectory currentDirectory)
        {
            var test = Directory.GetCurrentDirectory();
            
            SetTestData(
                new Data(
                    new List<PlayList>()
                    {
                        new PlayList(
                            "TestItem",
                            new List<MediaFile>()
                            {
                                new MediaFile("TestItem", @"Test\Path\To\File", ".mp4", "this is a test file", new Image("TestImage", @"Test\Path\To\File"), new List<Category>()
                                {
                                    new Category("TestItem")
                                } )
                            }
                            )
                    }
                    )
                );
            
            
            var result = dataService.RemoveItemIndependently("TestItem", currentDirectory);
            Assert.That(result, Is.EqualTo(true));
        }
        
        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void RemoveItemIndependently_WhenItemNameDoesNotExistsInCurrentDirectory_ReturnFalse(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.RemoveItemIndependently("TestItem", currentDirectory);
            Assert.That(result, Is.EqualTo(false));
        }


        #endregion

        #region GetAllChildren

        private static void SetFullTestDataForGetAllChildrenTests()
        {
            SetTestData(
                new Data(
                    new List<PlayList>()
                    {
                        new PlayList(
                            "TestPlayList",
                            new List<MediaFile>()
                            {
                                new MediaFile("TestItem", @"Test\Path\To\File", ".mp4", "this is a test file", new Image("TestImage", @"Test\Path\To\File"), new List<Category>()
                                {
                                    new Category("TestCategory")
                                } ),
                                new MediaFile("TestItem2", @"Test\Path\To\File", ".mp4", "this is a test file", new Image("TestImage", @"Test\Path\To\File"), new List<Category>()
                                {
                                    new Category("TestCategory")
                                } ),
                            }
                        )
                    }
                )
            );
        }

        [Test]
        public void GetAllChildren_WhenCurrentDirectoryIsNull_ReturnNull()
        {
            SetTestData(new Data());
            var result = dataService.GetAllChildren(new ListViewItem(), null);
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public void GetAllChildren_WhenSelectedItemIsNullAndEmptyInstanceOfCurrentDirectoryIsSetAndPlayListsExists_ReturnHashSetOfStrings()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(null, new CurrentDirectory());
            Assert.That(result, Is.TypeOf<HashSet<string>>());
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsNullAndEmptyInstanceOfCurrentDirectoryIsSetAndPlayListsDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(null, new CurrentDirectory());
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsSetAndEmptyInstanceOfCurrentDirectoryIsSetAndCategoriesExists_ReturnHashSetOfStrings()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(new ListViewItem() { Text = "TestPlayList"}, new CurrentDirectory());
            Assert.That(result, Is.TypeOf<HashSet<string>>());
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsSetAndEmptyInstanceOfCurrentDirectoryIsSetAndCategoriesDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(new ListViewItem() { Text = "TestPlayList"}, new CurrentDirectory());
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public void GetAllChildren_WhenSelectedItemIsBackButtonAndCurrentDirectoryPlayListIsSetAndPlayListsExists_ReturnHashSetOfStings()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(new ListViewItem() { Tag = "backButton"}, new CurrentDirectory("TestPlayList"));
            Assert.That(result, Is.TypeOf<HashSet<string>>());
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsBackButtonAndCurrentDirectoryPlayListIsSetAndPlayListsDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(new ListViewItem() { Tag = "backButton"}, new CurrentDirectory("TestPlayList"));
            Assert.That(result, Is.EqualTo(null));
        }

        [Test]
        public void GetAllChildren_WhenSelectedItemIsSetAndCurrentDirectoryPlayListIsSetAndFilesExists_ReturnHashSetOfStings()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(new ListViewItem() { Text = "TestCategory"}, new CurrentDirectory("TestPlayList"));
            Assert.That(result, Is.TypeOf<HashSet<string>>());
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsSetAndCurrentDirectoryPlayListIsSetAndFilesDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(new ListViewItem() { Text = "TestCategory"}, new CurrentDirectory("TestPlayList"));
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsNotSetAndCurrentDirectoryPlayListIsSetAndFilesExists_ReturnNull()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(null, new CurrentDirectory("TestPlayList"));
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsNotSetAndCurrentDirectoryPlayListIsSetAndFilesDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(null, new CurrentDirectory("TestPlayList"));
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsNullAndCurrentDirectoryCategoryIsSetAndFilesExists_ReturnNull()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(null, new CurrentDirectory(null, "TestCategory"));
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsNullAndCurrentDirectoryCategoryIsSetAndFilesDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(null, new CurrentDirectory(null, "TestCategory"));
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        // This works but as the file doesn't exist its try's opening a non existing file which it fails
        public void GetAllChildren_WhenSelectedItemIsSetAndCurrentDirectoryCategoryIsSetAndFilesExists_ReturnHashSetOfStrings()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(new ListViewItem() { Text = "TestItem" }, new CurrentDirectory(null, "TestCategory"));
            Assert.That(result, Is.TypeOf<HashSet<string>>());
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsSetAndCurrentDirectoryCategoryIsSetAndFilesDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(new ListViewItem() { Text = "TestItem" }, new CurrentDirectory(null, "TestCategory"));
            Assert.That(result, Is.EqualTo(null));
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsBackButtonAndCurrentDirectoryPlayListsAndCategoryIsSetAndCategoriesExists_ReturnHashSetOfStrings()
        {
            SetFullTestDataForGetAllChildrenTests();
            
            var result = dataService.GetAllChildren(new ListViewItem() { Tag = "backButton" }, new CurrentDirectory("TestPlayList", "TestCategory"));
            Assert.That(result, Is.TypeOf<HashSet<string>>());
        }
        
        [Test]
        public void GetAllChildren_WhenSelectedItemIsBackButtonAndCurrentDirectoryPlayListsAndCategoryIsSetAndCategoriesDoesNotExists_ReturnNull()
        {
            SetTestData(new Data());
            
            var result = dataService.GetAllChildren(new ListViewItem() { Tag = "backButton" }, new CurrentDirectory("TestPlayList", "TestCategory"));
            Assert.That(result, Is.EqualTo(null));
        }

        #endregion

        #region UpdateItemIndependently
        
        private static void SetFullTestDataForUpdateItemIndependently()
        {
            SetTestData(
                new Data(
                    new List<PlayList>()
                    {
                        new PlayList(
                            "TestItem",
                            new List<MediaFile>()
                            {
                                new MediaFile("TestItem", @"Test\Path\To\File", ".mp4", "this is a test file", new Image("TestImage", @"Test\Path\To\File"), new List<Category>()
                                {
                                    new Category("TestItem")
                                } ),
                                new MediaFile("TestItem", @"Test\Path\To\File", ".mp4", "this is a test file", new Image("TestImage", @"Test\Path\To\File"), new List<Category>()
                                {
                                    new Category("TestItem")
                                } ),
                            }
                        )
                    }
                )
            );
        }

        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void UpdateItemIndependently_WhenSelectedItemIsNull_ReturnFalse(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.UpdateItemIndependently(null, "newItemName", currentDirectory);
            Assert.That(result, Is.EqualTo(false));
        }
        
        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void UpdateItemIndependently_WhenNewItemNameIsNull_ReturnFalse(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.UpdateItemIndependently("selectedItem", null, currentDirectory);
            Assert.That(result, Is.EqualTo(false));
        }
        
        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void UpdateItemIndependently_WhenNewItemNameAndNewItemNameIsSetAndItemExists_ReturnTrue(CurrentDirectory currentDirectory)
        {
            SetFullTestDataForUpdateItemIndependently();
            var result = dataService.UpdateItemIndependently("TestItem", "newItemName", currentDirectory);
            Assert.That(result, Is.EqualTo(true));
        }
        
        [Test]
        [TestCaseSource("AllPossibleCurrentDirectoryValues")]
        public void UpdateItemIndependently_WhenNewItemNameAndNewItemNameIsSetAndItemDoesNotExists_ReturnFalse(CurrentDirectory currentDirectory)
        {
            SetTestData(new Data());
            var result = dataService.UpdateItemIndependently("TestItem", "newItemName", currentDirectory);
            Assert.That(result, Is.EqualTo(false));
        }

        #endregion
       
    }
}