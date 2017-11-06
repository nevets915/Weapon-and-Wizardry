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
        private TextBox _display;
        private List<ScriptLine> _scriptLines;
        private List<Button> _choiceButtons;
        private uint _choicePicked;
        private delegate void ScriptLine();

        /// <summary>
        /// Instantiates an instance of the ScriptEngine
        /// Requires a page as a parameter for interacting with the Page.
        /// Scripts are run in the sequential order starting from the
        /// first index in the collection.
        /// </summary>
        /// <param name="gui"></param>
        public ScriptEngine(TextBox display, List<Button> choiceButtons)
        {
            _currentExecutingLine = 0;
            _display = display;
            _scriptLines = new List<ScriptLine>();
            _choiceButtons = choiceButtons;
            LoadScripts();
        }

        public void ExecuteLine(uint choicePicked)
        {
            _choicePicked = choicePicked;
            _scriptLines[_currentExecutingLine].Invoke();
        }

        public void PrintTextDialogue(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
            _display.Text = message;            
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
    }
}