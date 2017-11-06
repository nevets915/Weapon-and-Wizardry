using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.App_Code
{
    /// <summary>
    /// Represents a script scenario that uses ScriptEngine API
    /// to dictate the game flow.
    /// </summary>
    public partial class ScriptEngine
    {
        private void LoadScripts()
        {
            _scriptLines.Add(Line1);
            _scriptLines.Add(Line2);
        }

        private void Line1()
        {
            SetChoiceButtons(new Choices("Fight", "Run"));
            PrintTextDialogue("Enemy appears");
            _currentExecutingLine++;
        }
        
        private void Line2()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(new Choices());
                    PrintTextDialogue("You attack!");
                    break;
                case 2:
                    SetChoiceButtons(new Choices());
                    PrintTextDialogue("You Run!");
                    break;
            }
            _currentExecutingLine++;
        }
    }
}