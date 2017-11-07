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
        static Choices nextChoice = new Choices("Next");

        private void LoadScripts()
        {
            _scriptLines.Add(Line1);
            _scriptLines.Add(Line2);
        }

        private void Line1()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Where am I…?\nA soft light fills the area," +
                "giving the atmosphere a solemn feel.\n ... Is this a dream?");
            _currentExecutingLine++;
        }

        private void Line2()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Oh brave hero…\nYou hear a beautiful voice begin to call you.\n" 
                + "The great goddess Ilias suddenly appears before you.");
            _currentExecutingLine++;
        }

        private void Line3()
        {
            SetChoiceButtons(new Choices("I can!", "Nope", "..."));
            PrintTextDialogue("Oh great hero… can you hear my voice?");
            _currentExecutingLine++;
        }

        private void Line4()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n"+
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
            _currentExecutingLine++;
        }

        private void Line5()
        {
            SetChoiceButtons(new Choices("I can!", "Nope", "..."));
            PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
            _currentExecutingLine++;
        }

        private void Line6()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("I have forseen that you will be the deciding factor"
                + "in bringing harmony or calamity to men and beast alike.\n" +
                "I am here to help guide you, so that you may live up to your full potential.");
            _currentExecutingLine++;
        }

        private void Line7()
        {
            SetChoiceButtons(new Choices("I'm the strongest there is.(Strength++)", "Speed's my game.(Dexterity++)", 
                "I know everything.(Intelligence++)", "I've always been very lucky (Luck++)"));
            PrintTextDialogue("Before we begin, I want to know more about you, oh great hero.\n" +
                "How would you describe yourself ?");
            _currentExecutingLine++;
        }

        private void Line8()
        {
            SetChoiceButtons(new Choices("I'm not very strong...(Strength--)", "I'm a little slow (Dexterity--)",
                "I've never been very bright.(Intelligence--)", "I'm super unlucky.(Luck--)"));
            PrintTextDialogue("What would you say is your biggest weakness?");
            _currentExecutingLine++;
        }

        private void Line9()
        {
            SetChoiceButtons(new Choices("I'm not very strong...(Strength--)", "I'm a little slow (Dexterity--)",
                "I've never been very bright.(Intelligence--)", "I'm super unlucky.(Luck--)"));
            PrintTextDialogue("What would you say is your biggest weakness?");
            _currentExecutingLine++;
        }

        private void Line99()
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