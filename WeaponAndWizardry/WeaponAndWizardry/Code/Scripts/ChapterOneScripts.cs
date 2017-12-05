using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.Code
{
    /// <summary>
    /// Container for the Script methods for the Prologue.
    /// </summary>
    public partial class WebGameEngine
    {
        private bool _stoleGoblet = false;

        public void LoadChapterOneScripts()
        {
            _scriptLines.Add(Ch1Line1);
            _scriptLines.Add(Ch1Line2);
            _scriptLines.Add(Ch1Line3);
            _scriptLines.Add(Ch1Line4);
            _scriptLines.Add(Ch1Line5);
            _scriptLines.Add(Ch1Line6);
            _scriptLines.Add(Ch1Line7);
            _scriptLines.Add(Ch1Line8);
            _scriptLines.Add(Ch1Line9);
            _scriptLines.Add(Ch1Line10);
            _scriptLines.Add(Ch1Line11);
            _scriptLines.Add(Ch1Line12);
            _scriptLines.Add(Ch1Line13);
            _scriptLines.Add(Ch1Line14);
            _scriptLines.Add(Ch1Line15);
            _scriptLines.Add(Ch1Line16);
            _scriptLines.Add(Ch1Line17);
            _scriptLines.Add(Ch1Line18);
            _scriptLines.Add(Ch1Line19);
            _scriptLines.Add(Ch1Line20);
            _scriptLines.Add(Ch1Line21);
            _scriptLines.Add(Ch1Line22);
            _scriptLines.Add(Ch1Line23);
            _scriptLines.Add(Ch1Line24);
            _scriptLines.Add(Ch1Line25);
            _scriptLines.Add(Ch1Line26);
            _scriptLines.Add(Ch1Line27);
            _scriptLines.Add(Ch1Line28);
            _scriptLines.Add(Ch1Line29);
            _scriptLines.Add(Ch1Line30);
            _scriptLines.Add(Ch1Line31);
            //_scriptLines.Add(Ch1Line32);
            //_scriptLines.Add(Ch1Line33);
        }

        private void Ch1Line1()
        {
            ClearImageDisplay();
            SetBackgroundImage("gameover.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Game over\nReturning to main menu.");
            //QuitGame();
        }

        private void Ch1Line2()
        {
            ClearImageDisplay();
            SetBackgroundImage("15.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Your journey is uneventful as you finally arrive just outside the capital.");
            _currentExecutingLine++;
        }

        private void Ch1Line3()
        {
            AddForegroundImage("Guard.png", 100, 20, 12, 640, 480);
            SetChoiceButtons(new Choices("\"I have a royal invitation.\"", "Hand him your royal invitation letter"));
            PrintTextDialogue("Before you enter the gates, you are halted by the royal guard.\n"+
                "\"HALT!\nState your name and your business.\"");
            _currentExecutingLine++;
        }

        private void Ch1Line4()
        {
            switch(_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"I have a royal invitation\"");
                    break;
            }
            PrintTextDialogue("You hand the guard your royal invitation letter.\n"+
                "He looks it over before handing it back to you.\n"+
                "\"Ah, you're the monster slayer.  Right this way, sire.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine = _currentExecutingLine + 2;
        }

        private void Ch1Line5()
        {
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"I have a royal invitation\"");
                    break;
            }
            PrintTextDialogue("You hand the guard your royal invitation letter.\n" +
                "He looks it over before handing it back to you.\n" +
                "\"Ah, you're the monster slayer. Right this way, sire.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line6()
        {
            ClearImageDisplay();
            SetBackgroundImage("44.png");
            PrintTextDialogue("The guard calls over an escort and they lead you into the city.\n"+
                "You pass by a number of noteworthy locations: item stores, libraries, notice boards, etc.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line7()
        {
            SetBackgroundImage("55.png");
            AddForegroundImage("Guard.png", 100, 20, 12, 640, 480);
            PrintTextDialogue("Eventually the guards, lead you into the royal hearing room to be seated.\n"+
                "\"Please mind your manners when addressing royalty.  You may keep your weaopn, but know that you will watched\"\n"+
                "The guards return to their posts and only the royal guards remain at the entrace of the room.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line8()
        {
            ClearForegroundImages();
            PrintTextDialogue("You look around the room.\nIt is filled with royal looking items, each of which could pay for your meals for a year.\n"+
                "The waiting begins to bore you and the royal items are just tempting you to steal them.\n"+
                "You could steal a few of the smaller items and sell them in the marketplace later.");
            SetChoiceButtons(new Choices("Steal some of the items (Dexterity check)", "Wait patiently"));
            _currentExecutingLine++;
        }

        private void Ch1Line9()
        {
            //Need to fix
            switch(_choicePicked)
            {
                case 1:
                    PrintTextDialogue("You look back at the two royal guards.\n"+
                        "They seem intent on watching your every move.  ");
                    if (Dex > Dexterity.Average)
                    {
                        PrintTextDialogue("You pace back and forth in the room and the guards begin to tire of watching you so closely.\n"
                            + "In that one instant, you sneak one of the large golden goblets into your pack and return to your seat.");
                        Align--;
                        _stoleGoblet = true;
                    }
                    else
                    {
                        AddForegroundImage("Guard.png", 100, 20, 12, 640, 480);
                        PrintTextDialogue("You attempt to steal one of the large golden goblets.\n"+
                            "However, one of the guards walk in front of you before your attempt.\n"+
                            "\"Don't even think about it.\"\n"+
                            "Unable to steal the goblet, you sit back down in your seat.");
                        Align--;
                        _stoleGoblet = false;
                    }
                    break;
                case 2:
                    PrintTextDialogue("You decide to just wait patiently. Stealing is wrong after all.");
                    break;
            }
            _currentExecutingLine++;
        }
        private void Ch1Line10()
        {
            ClearForegroundImages();
            PrintTextDialogue("Minutes pass as you begin to walk back and forth in boredom.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line11()
        {
            PrintTextDialogue("\"Ah, sorry!\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line12()
        {
            PrintTextDialogue("Something soft and sweet bumps into you.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine = _currentExecutingLine + 2;
        }

        private void Ch1Line13()
        {
            //extra method
        }

        private void Ch1Line14()
        {
            PrintTextDialogue("You take your hands and push back from the object.\n"+
                "You look down and realize it's...");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line15()
        {
            //AddForegroundImage();
            PrintTextDialogue("Princess Melty?!?");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line16()
        {
            PrintTextDialogue("Shocked by the sudden embrace with royalty, you immediately retreat before one of the guards decide to execute you.\n"+
                "You apologize furiously, before the princess reassures you.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line17()
        {
            PrintTextDialogue("\"Ah, it's my fault. I've always been a little clumsy.\"\n"+
                "You're taken back by the princess's humbleness. She gives off an aura that suits a favourable ruler.\n\nTop it all off, she's cute.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line18()
        {
            PrintTextDialogue("\"You're probably wondering why you're met with the princess instead of the king.\n"+
                "Truth is, I'm the one who requested you.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line19()
        {
            PrintTextDialogue("\"I've heard of your work, and I believe that you can help the capital with all of it's monster issues.\n"+
                "You've seen the notice board, correct? It's full of the people's problems with monsters.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line20()
        {
            PrintTextDialogue("\"However, I don't want the monsters to just be slaughtered. Some of them aren't bad, but most of the guards here can't tell the difference.\n"+
                "For that I need a specialist, like yourself.\n"+
                "Father and brother think it's best to destroy all monsters, so we will need to keep your mission a secret from them.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line21()
        {
            PrintTextDialogue("\"Please help with my request in aiding the people with monster attacks as peacefully as possible.\n" +
                "The princess makes a small bow to you, which shocks the two guards behind you.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line22()
        {
            PrintTextDialogue("\"Of course you will be well compensated for your time and effort\n" +
                "\"Will you accept my request?\"\n" +
                "The princess meekly looks at you with geninue concern.");
            SetChoiceButtons(new Choices("I'll do my best, princess.", "I'll do it... for a date."));
            _currentExecutingLine++;
        }

        private void Ch1Line23()
        {
            switch(_choicePicked)
            {
                case 1:
                    PrintTextDialogue("\"I'll do my best, princess.\"");
                    _currentExecutingLine = _currentExecutingLine + 2;
                    break;
                case 2:
                    if (Align == Alignment.Adored)
                    {
                        PrintTextDialogue("\"I'll do it... for a date.\"");
                        PrintTextDialogue("\"A d-date?!\"\n"+
                            "The princess looks surprised and a little embarassed.\n"+
                            "The two guards behind you are also angrily shocked by your request.");
                            _currentExecutingLine++;
                    }
                    else
                    {
                        PrintTextDialogue("\"I'll do it... for a date.\"");
                        PrintTextDialogue("\"Please don't joke around with a maiden's heart.\""+
                            "You feel the angry stares intensify from the two guards behind you.");
                        _currentExecutingLine = _currentExecutingLine + 2;
                    }
                    break;
            }
            SetChoiceButtons(nextChoice);
        }

        private void Ch1Line24()
        {
            PrintTextDialogue("Audible only to your ears, the princess whispers very softly.");
            PrintTextDialogue("\"I'll consider it.\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line25()
        {
            PrintTextDialogue("\"You will be of course, rewarded for your time and effort.\n"+
                "Please do your best.\"\n"+
                "The princess gives you one last smile before you take your leave.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line26()
        {
            PrintTextDialogue("\"You will be of course, rewarded for your time and effort.\n" +
                "Please do your best.\"\n" +
                "The princess gives you one last smile before you take your leave.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line27()
        {
            ClearImageDisplay();
            SetBackgroundImage("44.png");
            PrintTextDialogue("With your quest given, you decide to head over to the notice board.\n"+
                "You see quite a few requests for problems with monsters.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line28()
        {
            PrintTextDialogue("First notice: Monster slayer wanted! Court wizard requesting aid.\n"+
                "Second notice: Find missing adventurer. Went missing in the maze of the sphinx.\n"+
                "Third notice: Looking for Noble escort through monster-filled forest.");
            SetChoiceButtons(new Choices("Help the wizard", "Find the missing adventurer", "Become a noble escort."));
            _currentExecutingLine++;
        }

        private void Ch1Line29()
        {
            switch(_choicePicked)
            {
                case 1:
                    PrintTextDialogue("You decide to go and help the court wizard.\n"+
                        "You head to the wizard's hut which near the end of town.");
                    _currentExecutingLine++;
                    break;
                case 2:
                    PrintTextDialogue("You decide to go and help find the missing adventurer.\n"+
                        "You take the image of the missing adventurer and head towards the maze of the sphinx.");
                    _currentExecutingLine++;
                    break;
                case 3:
                    PrintTextDialogue("You decide to try your hand at becoming a noble escort. You head to the location specified by the contract.");
                    _currentExecutingLine++;
                    break;
            }
        }

        private void Ch1Line30()
        {
            ClearImageDisplay();
            PrintTextDialogue("On your way there, you ponder why someone as powerful as a wizard would request help.\n"+
                "Considering that a court wizard is a person wielding magic for the royal family, they should be able to easily get able-bodies to help them.\n"+
                "You put your thoughts on hold before entering the wizard's home.");
            _currentExecutingLine++;
        }

        private void Ch1Line31()
        {
            ClearImageDisplay();
            SetBackgroundImage("82.png");
            PrintTextDialogue("You knock before entering, but find out that no one appears to be home. You decide to wait for the wizard.\n"+
                "You see a couple of coloured potions sitting with the label, \"Highly experimental enhancers. Do NOT drink.\"\n"+
                "You could sample the potions to see what they do before the wizard arrives.");
            SetChoiceButtons(new Choices("Drink a potion", "Wait patiently."));
            _currentExecutingLine++;
        }

        private void Ch1Line32()
        {
            switch(_choicePicked)
            {
                case 1:
                    PrintTextDialogue("There are 4 potions sitting there. Some of them look a bit odd.\n"+
                        "A red one labeled, \"In case headaches.\"\n"+
                        "A violet one labeled, \"Better to be ___, than smart.\"\n" +
                        "A black one labeled, \"Fear the strong.\"\n" +
                        "A orange one labeled, \"Silver and Gold.\"\n"+
                        "Which one will you drink?" );
                    SetChoiceButtons(new Choices("The red one.", "The violet one", "The black one", "The orange one."));
                    _currentExecutingLine++;
                    break;
                case 2:
                    PrintTextDialogue("You decide not to drink any of the potions.\nWinners don't use drugs.");
                    _currentExecutingLine = _currentExecutingLine + 2;
                    break;
            } 
        }

        private void Ch1Line33()
        {
            switch(_choicePicked)
            {
                case 1:
                    PrintTextDialogue("You drink the red potion and suddenly your wounds are fully healed.");
                    HP = 100;
                    break;
                case 2:
                    PrintTextDialogue("You drink the violet potion and feel your mental abilities weaken."+
                        "However, you feel things will go your way somehow.");
                    Int--;
                    Luk++;
                    break;
                case 3:
                    PrintTextDialogue("You drink the black potion and suddenly your muscles begin to expand.\n"+
                        "Your appearance becomes more powerful and more threatening to those around you.");
                    Str++;
                    Align--;
                    break;
                case 4:
                    PrintTextDialogue("You drink the orange potion and suddenly gold appears in your hand.\n"+
                        "You count it out and there's at least 200 gold pieces here.");
                    Gold = Gold + 200;
                    break;
            }
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line34()
        {
            PrintTextDialogue("\"Admiring my potions are you?\"");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line35()
        {
            //Addforegroundimage
            PrintTextDialogue("A puff of smoke appears and suddenly the court wizard appears before you.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }

        private void Ch1Line70()
        {
            //Addforegroundimage
            PrintTextDialogue("A puff of smoke appears and suddenly the court wizard appears before you.");
            SetChoiceButtons(nextChoice);
            _currentExecutingLine++;
        }
    }
}