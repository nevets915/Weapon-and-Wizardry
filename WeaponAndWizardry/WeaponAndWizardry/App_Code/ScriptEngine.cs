using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WeaponAndWizardry.App_Code
{
    /// <summary>
    /// Handles execution of scenario scripts.
    /// Exposes API for Script class to use.
    /// </summary>
    public partial class ScriptEngine
    {
        private int _currentExecutingLine;
        private Panel _imageDisplay;
        private TextBox _textDisplay;
        private List<ScriptLine> _scriptLines;
        private List<Button> _choiceButtons;
        private uint _choicePicked;
        private Image _currentBackgroundImage;
        private List<Image> _currentForegroundImages;

        private delegate void ScriptLine();

        /// <summary>
        /// Instantiates an instance of the ScriptEngine
        /// Requires a page as a parameter for interacting with the Page.
        /// Scripts are run in the sequential order starting from the
        /// first index in the collection.
        /// </summary>
        /// <param name="gui"></param>
        public ScriptEngine(Panel imageDisplay, TextBox textDisplay, List<Button> choiceButtons)
        {
            _currentExecutingLine = 0;
            _imageDisplay = imageDisplay;
            _textDisplay = textDisplay;
            _scriptLines = new List<ScriptLine>();
            _currentForegroundImages = new List<Image>();
            _choiceButtons = choiceButtons;
            LoadScripts();
        }

        public void UpdateReferences(Panel imageDisplay, TextBox textDisplay, List<Button> choiceButtons)
        {
            _imageDisplay = imageDisplay;
            _textDisplay = textDisplay;
            _choiceButtons = choiceButtons;
        }

        public void ExecuteLine(uint choicePicked)
        {
            _choicePicked = choicePicked;
            _scriptLines[_currentExecutingLine].Invoke();
        }

        public void PrintTextDialogue(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            _textDisplay.Text = message;            
        }
        
        public void SetChoiceButtons(Choices choices)
        {
            for (int i = 0; i < _choiceButtons.Count; i++)
            {
                _choiceButtons[i].Enabled = true;
                _choiceButtons[i].Text = choices.Collection[i];
                if (String.IsNullOrWhiteSpace(_choiceButtons[i].Text))
                {
                    _choiceButtons[i].Enabled = false;
                }
            }
        }

        public void ClearImageDisplay()
        {
            _imageDisplay.Controls.Clear();
            _currentBackgroundImage = null;
            _currentForegroundImages.Clear();
        }

        public void ClearForegroundImages()
        {
            foreach(Image image in _currentForegroundImages)
            {
                _imageDisplay.Controls.Remove(image);
            }
            _currentForegroundImages.Clear();
        }

        public void SetBackgroundImage(string imageFileName)
        {
            _imageDisplay.Controls.Remove(_currentBackgroundImage);
            Image image = new Image();
            image.Style["position"] = "absolute";
            image.Style["z-index"] = "0";
            image.Style["left"] = "0px";
            image.Style["top"] = "0px";
            image.Width = 800;
            image.Height = 600;
            image.ImageUrl = "~/Content/images/backgrounds/" + imageFileName;
            _currentBackgroundImage = image;
            _imageDisplay.Controls.Add(_currentBackgroundImage);
        }

        public void AddForegroundImage(string url, int xPos, int yPos, int zPos, int width, int height)
        {
            Image image = new Image();
            image.Style["position"] = "absolute";
            image.Style["z-index"] = zPos.ToString();
            image.Style["left"] = xPos.ToString() + "px";
            image.Style["top"] = yPos.ToString() + "px";
            image.Width = width;
            image.Height = height;
            image.ImageUrl = "~/Content/" + url;
            _currentForegroundImages.Add(image);
            _imageDisplay.Controls.Add(image);
        }
    }
}