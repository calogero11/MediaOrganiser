using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MediaOrganiser.Interfaces;
using MediaOrganiser.Services;
using NUnit.Framework;

namespace MediaOrganiser.Tests.Services
{
    [TestFixture]
    public class ViewServiceTests
    {
        private IViewService viewService;
        private static readonly Color ActiveButtonColour = Color.FromArgb(240, 240, 240);
        private static readonly Color ActivePanelColour = Color.FromArgb(58, 211, 0);

        [SetUp]
        public void Setup()
        {
            viewService = new ViewService();
        }

        #region ActivateButton
        
        public static IEnumerable<TestCaseData> AllPossibleWaysActivateButtonParametersNotSet
        {
            get
            {
                return new []
                {
                    new TestCaseData(null, null, null, null),
                    new TestCaseData(null, null, null, new Panel()),
                    new TestCaseData(null, null, new Button(), null),
                    new TestCaseData(null, null, new Button(), new Panel()),
                    new TestCaseData(null, new Panel() { BackColor = ActivePanelColour}, new Button(), new Panel()),
                    new TestCaseData(null, new Panel() { BackColor = ActivePanelColour}, null, null),
                    new TestCaseData(null, new Panel() { BackColor = ActivePanelColour}, null, new Panel()),
                    new TestCaseData(null, new Panel() { BackColor = ActivePanelColour}, new Button(), null),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, null, null, null),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, null, null, new Panel()),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, null, new Button(), null),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, null, new Button(), new Panel()),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, new Panel() { BackColor = ActivePanelColour }, null, null),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, new Panel() { BackColor = ActivePanelColour }, null, new Panel()),
                    new TestCaseData(new Button() {BackColor = ActiveButtonColour}, new Panel() { BackColor = ActivePanelColour }, new Button(), null),
                 
                }; 
            }
        }
        
        [Test]
        public void ActivateButton_WhenAllParametersSet_ReturnTupleWithButtonAndPanelSetWithCorrectColours()
        {
            var activeButton = new Button() { BackColor = ActiveButtonColour };
            var activePanel = new Panel() { BackColor = ActivePanelColour };
            
            var result = viewService.ActivateButton(activeButton, activePanel, new Button(), new Panel());
            Assert.That(result, Is.TypeOf<(Button, Panel)>());
            Assert.That(result.Item1.BackColor, Is.EqualTo(ActiveButtonColour));
            Assert.That(result.Item2.BackColor, Is.EqualTo(ActivePanelColour));
        }

        [Test]
        [TestCaseSource("AllPossibleWaysActivateButtonParametersNotSet")]
        public void ActivateButton_WhenAnyParametersNotSet_ReturnReturnTupleWithNullAndNul(Button fromActiveButton, Panel fromActivePanel, Button toActiveButton, Panel toActivePanel)
        {
            var result = viewService.ActivateButton(fromActiveButton, fromActivePanel, toActiveButton, toActivePanel);
            
            Assert.That(result, Is.TypeOf<(Button, Panel)>());
            Assert.That(result.Item1, Is.EqualTo(null));
            Assert.That(result.Item2, Is.EqualTo(null));
        }

        #endregion
    }   
}       