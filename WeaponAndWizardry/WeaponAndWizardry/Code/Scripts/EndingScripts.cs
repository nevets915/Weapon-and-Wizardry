using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Module: WebGameEngine
    /// Description: Container for ending scripts which tell the engine 
    /// what order the instructions should go in.
    /// Author: Steven Ma			Date: 2017-11-30 
    /// </summary>
    public partial class WebGameEngine
    {
        /// <summary>
        /// Region containing a method for loading the scripts needed.
        /// </summary>

        #region Script Load
        public void LoadEndingScript()
        {
            _scriptLines.Add(EndingLine1);
            _scriptLines.Add(EndingLine2);
            _scriptLines.Add(EndingLine3);
            _scriptLines.Add(EndingLine4);
            _scriptLines.Add(EndingLine5);
            _scriptLines.Add(EndingLine6);
            _scriptLines.Add(EndingLine7);
            _scriptLines.Add(EndingLine8);
            _scriptLines.Add(EndingLine9);
            _scriptLines.Add(EndingLine10);
            _scriptLines.Add(EndingLine11);
            _scriptLines.Add(EndingLine12);
            _scriptLines.Add(EndingLine13);
            _scriptLines.Add(EndingLine14);
            _scriptLines.Add(EndingLine15);
            _scriptLines.Add(EndingLine16);
            _scriptLines.Add(EndingLine17);
            _scriptLines.Add(EndingLine18);
            _scriptLines.Add(EndingLine19);
            _scriptLines.Add(EndingLine20);
            _scriptLines.Add(EndingLine21);
            _scriptLines.Add(EndingLine22);
            _scriptLines.Add(EndingLine23);
            _scriptLines.Add(EndingLine24);

        }

        #endregion

        /// <summary>
        /// Region containing the script methods, each containing what's needed for the next
        /// line of dialogue.
        /// </summary>

        #region Scripts

        private void EndingLine1()
        {
            ClearImageDisplay();
            SetBackgroundImage("87.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Suddenly a flash of light blinds your eyes.\n" +
                "You've felt this sensation before.");
        }

        private void EndingLine2()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Ilias_neutral.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Hello user, thank you for participating in this version of Weapons and Wizardry.\n" +
                "We hoped you enjoyed a taste of what Group 7 can offer.\"");
            _currentExecutingLine++;
        }

        private void EndingLine3()
        {
            ClearForegroundImages();
            AddForegroundImage("Ilias_closed1.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Unforutnately, the deadline for this project has come to a close.\n" +
                "This means that the story portion remains unfinished.\n" +
                "Perhaps someday, we will be able to add more content to this project.\"");
            _currentExecutingLine++;
        }

        private void EndingLine4()
        {
            ClearForegroundImages();
            AddForegroundImage("Ilias_neutral.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"If you had a good experience so far, please comment in the following survey provided by one of the developers.\n" +
                "Project Lead: George Lee\nStory Designer: Steven Ma\nGame Visuals Designer: Shawn Kim\"");
            _currentExecutingLine++;
        }

        private void EndingLine5()
        {
            ClearForegroundImages();
            AddForegroundImage("Ilias_happy.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(new Choices("Princess Melty"));
            PrintTextDialogue("\"Before we end off, I would like to show you just a glimpse of one of the possible endings to this game as a thank you.\"");
            PrintTextDialogue("\"Please select a character ending you wish to view.\"");
            _currentExecutingLine = _currentExecutingLine + 2;
        }
        //"Hero Damian", "Royal escort Isis", "Other"

        private void EndingLine6()
        {
            SetChoiceButtons(new Choices("Princess Melty", "Hero Damian"));
            PrintTextDialogue("\"Please select a character ending you wish to view.\"");
            _currentExecutingLine++;
        }
        //, "Hero Damian", "Royal escort Isis", "Other"

        private void EndingLine7()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"Excellent choice. I'm sure you and the princess will be happy.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine = _currentExecutingLine + 3;
                    break;
                case 2:
                    PrintTextDialogue("\"A sucker for the hero-types, huh?\n" +
                        "Many blessings upon you.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine = _currentExecutingLine + 18;
                    break;
                case 3:
                    PrintTextDialogue("\"A beautiful rose, has thorns does it not?\n" +
                        "Enjoy your life together, hero.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 4:
                    PrintTextDialogue("\"Hmm? Is there another you wish to view?\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
            }
        }

        private void EndingLine8()
        {
            PrintTextDialogue("\"Please select a character ending you wish to view.\"");
            SetChoiceButtons(new Choices("Court Wizard Albus", "You", "Monster Queen Alice", "Back"));
            _currentExecutingLine++;
        }

        private void EndingLine9()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"A wizard with a destiny for greatness.\n" +
                        "You've chosen well.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 2:
                    PrintTextDialogue("\"As you wish. I...\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 3:
                    PrintTextDialogue("\"My, my. What a greedy hero I've raised.\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 4:
                    PrintTextDialogue("\"Hmm? Is there another you wish to view?\"");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine = _currentExecutingLine - 3;
                    break;
            }
        }

        private void EndingLine10()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            PrintLineTextDialogue("You awake in your royal styled chambers.\n" +
                "It has been several weeks since you saved the kingdom from calamity.\n" +
                "Since then, you've been crowned a hero of the era.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine11()
        {
            PrintLineTextDialogue("This of course came with castles, money and everything you could ever hope for.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine12()
        {
            PrintLineTextDialogue("You attempt to stand up from your bed, but are stopped by a very familiar soft embrace.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine13()
        {
            PrintLineTextDialogue("\"Nnnn, 5 more minutes, honey.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine14()
        {
            PrintLineTextDialogue("Oh, and you got married to the princess.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine15()
        {
            ClearImageDisplay();
            SetBackgroundImage("11.png");
            AddForegroundImage("Princess_blush.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"The kingdom can wait a little bit longer.\n" +
                "I'll give you a kiss if you stay.\"" +
                "The princess smiles playfully at you.");
            SetChoiceButtons(new Choices("Kiss her.", "Don't kiss her."));
            _currentExecutingLine++;
        }

        private void EndingLine16()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintLineTextDialogue("You chuckle lightly and bring the princess close to you.\n" +
                        "Your lips slowly close in to meet the princess's");
                    break;
            }
            PrintLineTextDialogue("Suddenly you hear a knock at the door.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine17()
        {
            ClearForegroundImages();
            AddForegroundImage("Guard.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"My lord and my lady. Your presence is required for your royal coronation. \n" +
                "Please hurry as we are already behind schedule.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine18()
        {
            ClearForegroundImages();
            AddForegroundImage("Princess_happy.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("You sigh and the princess giggles gleefully as you reluctantly get dressed.\n" +
                "\"Don't worry, love. We can spend more time together once we're done our royal duties.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine19()
        {
            ClearForegroundImages();
            AddForegroundImage("Princess_neutral.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("You smile back at the princess and make your way to the door of your chambers.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine20()
        {
            ClearForegroundImages();
            AddForegroundImage("Princess_blush.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"Oh and don't forget this.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine21()
        {
            ClearForegroundImages();
            AddForegroundImage("Princess_kiss.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("You turn around and before you know it, the princess gives you a sweet, loving kiss and a soft embrace.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine22()
        {
            ClearForegroundImages();
            AddForegroundImage("Princess_blush.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("The princess whispers softly in your ear before sending you on your way.\n" +
                "\"I love you.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine23()
        {
            ClearForegroundImages();
            PrintLineTextDialogue("You leave your chambers with a big grin on your face as your royal guards escort you.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine24()
        {
            ClearImageDisplay();
            SetBackgroundImage("88.png");
            PrintLineTextDialogue("A king's job is never done.");
            SetChoiceButtons(new Choices("Back to Main menu."));
            _currentExecutingLine = _currentExecutingLine + 11;
        }

        private void EndingLine25()
        {
            ClearImageDisplay();
            SetBackgroundImage("69.png");
            PrintLineTextDialogue("CLANK! CLASH! WOOSH!");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine26()
        {
            AddForegroundImage("Minotaur_neutral.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"GRAWWWWW!\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine27()
        {
            PrintLineTextDialogue("You deal a savage blow to the minotuar, but it's still not going down.\n" +
                "You prep yourself for another attack.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine28()
        {
            PrintLineTextDialogue("\"ME SMASH PUNY MAN!\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine29()
        {
            PrintLineTextDialogue("The minotaur lunges at you with a desperate rush attack.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine30()
        {
            PrintLineTextDialogue("However, just before the attack comes near, a familiar figure appears in front of you.\n" +
                "\"Dibs!\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine31()
        {
            ClearForegroundImages();
            AddForegroundImage("Damian_shouting.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"This one's mine, love.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine32()
        {
            PrintLineTextDialogue("\"Single sword: Lion strike!\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine33()
        {
            ClearForegroundImages();
            AddForegroundImage("Minotaur_defeat.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("The minotaur howls in pain before crashing downwards.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine34()
        {
            ClearForegroundImages();
            PrintLineTextDialogue("It's been several weeks since you've saved the kingdom.\n" +
                "Since then, you've been keeping busy by training your sword skills, earning monster bounties and travelling the world.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine35()
        {
            PrintLineTextDialogue("To keep you company, you've decided to party with the great hero, Damian.\n" +
                "Since the two of you met, you've accomplished great things together and become monster-slaying partners, comrades and..." +
                "possible lovers?");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine36()
        {
            ClearForegroundImages();
            AddForegroundImage("Damian_happy.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"Yes! I finally beat you too it, love. \n" +
                "Dinner's on me.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine37()
        {
            PrintLineTextDialogue("\"You may be known as the Hero of Legend, but tonight I get to treat you.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine38()
        {
            PrintLineTextDialogue("\"So, what do you think? Should fetch a pretty penny.\"\n" +
                "Damian holds out the minotaur's head.");
            SetChoiceButtons(new Choices("Tease him"));
            _currentExecutingLine++;
        }

        private void EndingLine39()
        {
            ClearForegroundImages();
            AddForegroundImage("Damian_blush.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"Hehe, not bad, hero. Perhaps you deserve a kiss.\n" +
                "Not many people get to experience a kiss from the Hero of Legend.\"");
            PrintLineTextDialogue("\"Damian begins to blush in anticipation.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine40()
        {
            PrintLineTextDialogue("\"Y-you mean it? For real?!\"");
            SetChoiceButtons(new Choices("Kiss him", "Troll him"));
            _currentExecutingLine++;
        }

        private void EndingLine41()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintLineTextDialogue("You giggle slyly and lean close to your embarassed companion.\n" +
                        "You give him a light kiss and a quick embrace.");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
                case 2:
                    PrintLineTextDialogue("You giggle slyly and lean close to your embarassed companion.\n" +
                        "You poke his cheek lightly and look deeply into his embarssed eyes.");
                    SetChoiceButtons(nextChoice);
                    _currentExecutingLine++;
                    break;
            }

        }

        private void EndingLine42()
        {
            ClearForegroundImages();
            AddForegroundImage("Damian_embarass.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("Minutes pass before the two of you separate.");
            PrintLineTextDialogue("\"That was nice. I-I uhh, don't know what else to say.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine43()
        {
            PrintLineTextDialogue("\"I love you. You're a hero similar to my calibur\", you confess to Damian.");
            PrintLineTextDialogue("Embarassed by your own feelings, you try to think of a way of skipping the awkwardness of new couples.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine44()
        {
            ClearForegroundImages();
            PrintLineTextDialogue("Quickly, you snatch the minotaur head from the infatuated hero's grasp and take off for the bounty.");
            PrintLineTextDialogue("\"But, you haven't caught my heart yet\", you shout back at Damian as you speed ahead.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine45()
        {
            ClearForegroundImages();
            AddForegroundImage("Damian_happy.png", 100, 20, 12, 640, 480);
            PrintLineTextDialogue("\"Heh, that's the one I know and love.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void EndingLine46()
        {
            ClearImageDisplay();
            SetBackgroundImage("88.png");
            PrintLineTextDialogue("\"My hero.\"");
            SetChoiceButtons(new Choices("Back to Main menu."));
            _currentExecutingLine++;
        }

        private void EndingLine47()
        {
            QuitGame(SessionHandler.MainScene);
        }
        #endregion
    }
}