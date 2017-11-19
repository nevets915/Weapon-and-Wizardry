using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WeaponAndWizardry.App_Code
{
    public partial class ScriptEngine
    {
        public void LoadPrologueScripts()
        {
            _scriptLines.Add(Prologue1);
            _scriptLines.Add(Prologue2);
            _scriptLines.Add(Prologue3);
            _scriptLines.Add(Prologue4);
            _scriptLines.Add(Prologue5);
            _scriptLines.Add(Prologue6);
            _scriptLines.Add(Prologue7);
            _scriptLines.Add(Prologue8);
            _scriptLines.Add(Prologue9);
            _scriptLines.Add(Prologue10);
            _scriptLines.Add(Prologue11);
            _scriptLines.Add(Prologue12);
            _scriptLines.Add(Prologue13);
            _scriptLines.Add(Prologue14);
            _scriptLines.Add(Prologue15);
            _scriptLines.Add(Prologue16);
            _scriptLines.Add(Prologue17);
            _scriptLines.Add(Prologue18);
            _scriptLines.Add(Prologue19);
            _scriptLines.Add(Prologue20);
            _scriptLines.Add(Prologue21);
            _scriptLines.Add(Prologue22);
            _scriptLines.Add(Prologue23);
            _scriptLines.Add(Prologue24);
            _scriptLines.Add(Prologue25);
            _scriptLines.Add(Prologue26);
            _scriptLines.Add(Prologue27);
            _scriptLines.Add(Prologue28);
            _scriptLines.Add(Prologue29);
            _scriptLines.Add(Prologue30);
            _scriptLines.Add(Prologue31);
            _scriptLines.Add(Prologue32);
            _scriptLines.Add(Prologue33);
            _scriptLines.Add(Prologue34);
            _scriptLines.Add(Prologue35);
            _scriptLines.Add(Prologue36);
            _scriptLines.Add(Prologue37);
            _scriptLines.Add(Prologue38);
            _scriptLines.Add(Prologue39);
            _scriptLines.Add(Prologue40);
            _scriptLines.Add(Prologue41);
            _scriptLines.Add(Prologue42);
            _scriptLines.Add(Prologue43);
        }

        private void Prologue1()
        {
            ClearImageDisplay();
            SetBackgroundImage("01.png");
            AddForegroundImage("Avatar1.jpg", 50, 50, 1, 200, 200);

            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Where am I…?\"\nA soft light fills the area," +
                "giving the atmosphere a solemn feel.\n ... \"Is this a dream?\"");
            _currentExecutingLine++;
        }

        private void Prologue2()
        {
            ClearForegroundImages();
            SetBackgroundImage("02.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Oh brave hero…\"\nYou hear a beautiful voice begin to call you.\n"
                + "The great goddess Ilias suddenly appears before you.");
            _currentExecutingLine++;
        }

        private void Prologue3()
        {
            ClearImageDisplay();
            SetBackgroundImage("13.png");
            SetChoiceButtons(new Choices("\"I can!\"", "\"Nope.\"", "\"...\""));
            PrintTextDialogue("\"Oh great hero… can you hear my voice?\"");
            _currentExecutingLine++;
        }

        private void Prologue4()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"I can!\"");
                    PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"Nope.\"");
                    PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
                    _currentExecutingLine++;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"...\"");
                    PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.");
                    _currentExecutingLine++;
                    break;
            }
        }

        private void Prologue5()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"I have forseen that you will be the deciding factor"
                + "in bringing harmony or calamity to men and beast alike.\n" +
                "Whether your destiny leads to that of rightous paragon or" +
                "a ruthless renagede. I am here to help guide you, so that " +
                "you may live up to your full potential.\"");
            _currentExecutingLine++;
        }

        private void Prologue6()
        {
            SetChoiceButtons(new Choices("\"I'm the strongest there is.(Strength++)\"", "\"Speed's my game.(Dexterity++)\"",
                "\"I know everything.(Intelligence++)\"", "\"I've always been very lucky (Luck++)\""));
            PrintTextDialogue("\"Before we begin, I want to know more about you, oh great hero.\n" +
                "How would you describe yourself?\"");
            _currentExecutingLine++;
        }

        private void Prologue7()
        {
            PrintTextDialogue("\"What would you say is your biggest weakness?\"");
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(new Choices("\"I'm a little slow (Dexterity--)\"",
                "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));

                    break;

                case 2:
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"",
                                    "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));

                    break;

                case 3:
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                        "\"I'm super unlucky.(Luck--)\""));

                    break;

                case 4:
                    SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                "\"I've never been very bright.(Intelligence--)\""));

                    break;
            }

            _currentExecutingLine++;
        }

        private void Prologue8()
        {
            switch (_choicePicked)
            {
                case 1:
                    //str++

                    break;

                case 2:
                    //dex++
                    break;

                case 3:
                    //int++
                    break;

                case 4:
                    //luck++
                    break;
            }
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("More text added here for tutorial");
            _currentExecutingLine++;
        }

        //More dialogue here?

        private void Prologue9()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Farewell, brave hero.\n  Know that I will always be watching over you, " +
                "even in the tutorial section.\"");
            _currentExecutingLine++;
        }

        private void Prologue10()
        {
            ClearImageDisplay();
            SetBackgroundImage("13.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You suddenly wake up to see the camp you made last night.\n" +
                "A dream about Ilias.\n \"I wonder what sort of great destiny " +
                "I could possibly have.\"");
            _currentExecutingLine++;
        }

        private void Prologue11()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You check around your camp belongings as you ponder your thoughts. \n" +
                "Your possessions include: your sword, a monster" +
                "slaying contract and typical camping necessities.");
            _currentExecutingLine++;
        }

        private void Prologue12()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You open the contract scroll among your belongings.\n" +
                "\"Contract: Slay the beast of Granberia.\n Reward will be given by Granberia's village chief.\"");
            _currentExecutingLine++;
        }

        private void Prologue13()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You recall that you camped near the Granberia city to hopefully slay the beast " +
                "and collect the bounty." +
                "\nTo make ends meet, you took up your sword and began slaying monsters for a living for a couple years now." +
                "\"Man’s gotta eat after all.\"");
            _currentExecutingLine++;
        }

        private void Prologue14()
        {
            SetBackgroundImage("11.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You make your way along the road to the city of Granberia.");
            _currentExecutingLine++;
        }

        private void Prologue15()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"HELP ME!\"");
            _currentExecutingLine++;
        }

        private void Prologue16()
        {
            SetChoiceButtons(new Choices("Rush over to find out who's calling for help", "Ignore it"));
            PrintTextDialogue("You hear someone shouting nearby");
            _currentExecutingLine++;
        }

        private void Prologue17()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(new Choices("Attempt to rescue the soldier", "Ignore"));
                    PrintTextDialogue("You rush over and see a soldier tied up, being attacked by goblins.\n" +
                "What do you do?");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +
                        "You continue on your way towards Granberia. ");
                    _currentExecutingLine = _currentExecutingLine + 17;
                    break;
            }
        }

        private void Prologue18()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You rush over with your sword in hand.The goblins are alerted to your presence.\n"
                + "\"KREEE!KREEE!\"");
            _currentExecutingLine++;
        }

        private void Prologue19()
        {
            SetChoiceButtons(new Choices("Attack with your sword", "Flee", "Intimidate them with a battle-cry (Strength)"));
            PrintTextDialogue("You’re outnumbered 3-to-1.  However, you know that goblins are generally cowards" +
                " and will flee if they think the odds are against them.\n  What do you do?");
            _currentExecutingLine++;
        }

        private void Prologue20()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("With your sword in hand, you attempt to slice the biggest goblin in two.\n" +
                    "However, you swing doesn’t go clean through and the goblin is able to retaliate.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +
                        "You continue on your way towards Granberia. ");
                    _currentExecutingLine = _currentExecutingLine + 14;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide the best course of action would be to bluff your way to victory.\n" +
                    "You bellow a battle cry with all your might.");
                    _currentExecutingLine = _currentExecutingLine + 4;
                    break;
            }
        }

        private void Prologue21()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("With your sword in hand, you attempt to slice the biggest goblin in two.\n" +
            "However, you swing doesn’t go clean through and the goblin is able to retaliate ");
            _currentExecutingLine++;
        }

        private void Prologue22()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The goblin is now badly wounded and is open " +
                "for your next attack which cleaves the goblin in two.\n  \"KREEE!Kree... \"");
            _currentExecutingLine++;
        }

        private void Prologue23()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The big goblin goes crashing down.  His two companions now fear stricken," +
                "flee for their lives.  \nTired from the ordeal, you decide not to give chase.");
            _currentExecutingLine++;
        }

        private void Prologue24()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"COME FORTH YOU SHALL FIND NO HONOUR IN DEATH!\"");
            _currentExecutingLine++;
        }

        private void Prologue25()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Your cry succeeds in intimidating the three goblins.\n" +
                "They all look to each other in fear and run away.\n" +
                "You decide not pursue them since you’ve already won the battle.\n" +
                "\"That was some shout,\" you hear the soldier comment.");
            _currentExecutingLine++;
        }

        private void Prologue26()
        {
            SetChoiceButtons(new Choices("Untie him", "Ask him why he’s tied up", "Leave him to the monsters",
                "Kill him and loot him"));
            PrintTextDialogue("\"Thank you.  My name is John Verdan.  Now quick, untie me!  More of those things could appear\"\n" +
                "The tied up soldier is now asking for your assistance.  His fate is in your hands.\n" +
                "What do you do?");
            _currentExecutingLine++;
        }

        private void Prologue27()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to untie the ropes around the soldier's arms and legs. \n" +
                        "\"Thanks. Now, I’m gonna get out of here before more of those goblins show up. " +
                        "\nI promise I’ll pay you back someday.The soldier rushs away, quick to leave the area.\""
                    );
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(new Choices("\"No\"", "\"Fine, fine.  I'll untie you.\""));
                    PrintTextDialogue("\"What? Can’t you just untie me first?\"");
                    _currentExecutingLine++;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide the best course of action would be to bluff your way to victory.\n" +
                    "You bellow a battle cry with all your might.");
                    _currentExecutingLine = _currentExecutingLine + 4;
                    break;
            }
        }

        private void Prologue28()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to continue onwards with your journey.");
            _currentExecutingLine++;
        }

        private void Prologue29()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to continue onwards with your journey.");
            _currentExecutingLine++;
        }

        private void Prologue30()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"But I… Ugh, okay fine.  I’m tied up because I’m a deserter.\n" +
                "I left the army because I’m a coward who doesn’t want to die.  \n" +
                "With so much political instability, nations aren’t so keen on sharing at the moment.\"");
            _currentExecutingLine++;
        }

        private void Prologue31()
        {
            SetChoiceButtons(new Choices("Untie him", "Leave him to the monsters", "Kill him and loot him"));
            PrintTextDialogue("\"I’m not that nationalistic, but I needed money to buy food to survive.  \n" +
            "It’s hard making a living in this day and age.  I joined the army to make ends meet, but… well you know.\"");
            switch (_choicePicked)
            {
                case 1:
                    _currentExecutingLine = _currentExecutingLine - 2;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to leave the soldier tied up as you begin to leave." +
                        "\n \"What? Hey, you can't leave me here! Please, please don't let me die! I don't wanna die!" +
                        "Despite the soldier's cries, you leave and continue on your journey.");
                    _currentExecutingLine = _currentExecutingLine + 3;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You slowly walk around the tired up soldier, inspecting him from behind.\n" +
                        "\"So... how about it? Free me please?\"\n " +
                        "You raise your sword and aim for a quick execution-style cut. \n" +
                        "\"What the - !What are you doing ? I…-\"");
                    _currentExecutingLine++;
                    break;
            }
        }

        private void Prologue32()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You swing your sword and decapitate the soldier.\n" +
                "The soldier's head comes clean off and his body lands lifeless on the floor.\n" +
                "Unmoved by your recent murder, you search the soldier's body for loot.");
            _currentExecutingLine++;
        }

        private void Prologue33()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Unsurprisingly, the body has nothing of value.\n You decide to continue on your journey.");
            _currentExecutingLine++;
        }

        private void Prologue34()
        {
            ClearImageDisplay();
            SetBackgroundImage("3.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You finally arrive in Granberia.  The town is decently sized compared to your expectations.\n" +
                "The town seemed to contain no more than 100 citizens and they ranged from children to the elderly.");
            _currentExecutingLine++;
        }

        private void Prologue35()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You begin exploring the village and eventually spot the village chief's house. \n" +
                "The door isn't locked, so you let yourself in.");
            _currentExecutingLine++;
        }

        private void Prologue36()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Upon entering, you meant a very elderly man. \n" +
                "He seemed a little anxious from his pacing back and forth.");
            _currentExecutingLine++;
        }

        private void Prologue37()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Ah, you must be a slayer who accepted the contract.  I can tell from your monster-slaying medallion.\n" +
            "\"Please have a seat.\" \nThe old man motions to a seat before him. \n\"My name is Merle.");
            _currentExecutingLine++;
        }

        private void Prologue38()
        {
            SetChoiceButtons(new Choices("\"Double the reward or I walk, old man.\"", "\"I accept the contract.\""));
            PrintTextDialogue("\"As you know, our village is currently being attacked by an unknown monster.\n" +
                "It seems to happen at random times.  The most recent attack was near the stables of our village.\n" +
                "Please I beg you to help us.\n  The reward of 500 gold pieces.  ");
            _currentExecutingLine++;
        }

        private void Prologue39()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"D-Double?!? But I... The village...\"\n The village chief sighs.\n " +
                        "\"If it will save our village, I will pay any price.\n You have a deal.\"");
                    _currentExecutingLine = _currentExecutingLine + 2;
                    break;

                case 2:
                    SetChoiceButtons(new Choices("\"Fine, I'll do the deed for 500 gold.\""));
                    PrintTextDialogue("\"D-Double?!? That's outragous. \nI could hire 10 mercenaries for that kind " +
                        "of money.  \nNo deal.\" \nThe old man looks sternly back at you.  It's unlikely he will change his mind.");
                    _currentExecutingLine++;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("\"Very good.  \nPlease slay the beast and bring me it's head as proof.  " +
                        "\nOnly then will you be paid.\" The old man motions you to leave as he has other matters to attend to.");
                    _currentExecutingLine = _currentExecutingLine + 2;
                    break;
            }
        }

        private void Prologue40()
        {
            SetChoiceButtons(new Choices("\"Fine, I'll do the deed for 500 gold.\""));
            _currentExecutingLine++;
        }

        private void Prologue41()
        {
            SetChoiceButtons(new Choices("Ask around the village marketplace for information.", "Ask for info around the center of town.", "Go to the most recent murder scene to search for clues."));
            PrintTextDialogue("With the deal set, you leave the village chief's house.\n" +
                "You need to slay the beast that's been kill all the villagers.\nHowever, you'll need to find the beast first.\nWhat do you do?");
            _currentExecutingLine++;
        }

        private void Prologue42()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to head to the marketplace to ask around for information.");
                    _currentExecutingLine = _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to ask around the center of town.");
                    _currentExecutingLine = _currentExecutingLine + 7;
                    break;

                case 3:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to go to the area of town where the most recent villager death was.");
                    _currentExecutingLine = _currentExecutingLine + 13;
                    break;
            }
        }

        private void Prologue43()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The marketplace is bustling with people of all ages, buying and selling goods.\n" +
                "You spot one of the free shopkeepers and ecide to ask them about.");
            _currentExecutingLine++;
        }

        private void Prologue44()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Selling the finest clothes in all of Granberia! Get 'em quick before they're gone!\"\n"
                + "The store owner does'nt seems to notice you at first.");
            _currentExecutingLine++;
        }

        private void Prologue45()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Selling the finest clothes in all of Granberia! Get 'em quick before they're gone!\"\n"
                + "The store owner doesn't seems to notice you at first.\"");
            _currentExecutingLine++;
        }

        private void Prologue46()
        {
            SetChoiceButtons(new Choices("I'm looking for information", "How's business?", "..."));
            PrintTextDialogue("\"Eh? Now what do you want?  I don't suppose you're gonna buy something.  \"");
            _currentExecutingLine++;
        }

        /// <summary>
        /// Choice doesn't matter here, shopkeeper is uncooperative.
        /// </summary>
        private void Prologue47()
        {
            SetChoiceButtons(new Choices("Ask for info around the center of town.", "Go to the most recent murder scene to search for clues."));
            PrintTextDialogue("\"I'm not here to make conversation, pal.  Either buy something or leave\"\n" +
                "Another wave of customers come by and the store owner immediately ignores you to tend to them.\n" +
                "Seems the marketplace is far too busy to get any useful information.\nWhat wilil you try next?");
            _currentExecutingLine++;
        }

        private void Prologue48()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to ask around the center of town.");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to go to the area of town where the most recent villager death was.");
                    _currentExecutingLine = _currentExecutingLine + 7;
                    break;
            }
        }

        private void Prologue49()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The center of town fairly empty at the moment.\n" +
                "The only people you see are a couple of kids playing with a softball.");
            _currentExecutingLine++;
        }

        private void Prologue50()
        {
            SetChoiceButtons(new Choices("\"Sure!\"", "\"Beat it,kid\""));
            PrintTextDialogue("You are about to leave when the halfing children approach you." +
                "\"Hey, you wanna play ball? C'mon it'll be fun!\"");
            _currentExecutingLine++;
        }

        private void Prologue51()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to play with the children for a bit.\n" +
                        "Despite their small size, the children are quite good.\n" +
                        "\"You're not bad. Best adult I've ever played with.\"");
                    _currentExecutingLine++;
                    break;

                case 2:
                    SetChoiceButtons(new Choices("Ask around the village marketplace for information.", "Go to the most recent murder scene to search for clues."));
                    PrintTextDialogue("\"Aww, you're no fun. Adults are so boring.\"" +
                        "\nThe children leave you. Seems there's nothing else here that will help you progress.\n" +
                        "Where should you head next?");
                    _currentExecutingLine = _currentExecutingLine + 3;
                    break;
            }
        }

        private void Prologue52()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The children all begin asking you about your sword, what you do for a living, etc.\n" +
                "\"A monster hunter? So cool.  Hope you can slay the one that's been attacking our village. " +
                "You should check by the stables, that's where the last monster attack was.\"" +
                "The children wave good-bye as they called back by their mother.");
            _currentExecutingLine++;
        }

        private void Prologue53()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The children made a good point about where you should search next. " +
                "You decide to take their advice and head towards the village stables.");
            _currentExecutingLine = _currentExecutingLine + 2;
        }

        private void Prologue54()
        {
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to head to the marketplace to ask around for information.");
                    _currentExecutingLine = _currentExecutingLine - 11;
                    break;

                case 2:
                    SetChoiceButtons(nextChoice);
                    PrintTextDialogue("You decide to go to the area of town where the most recent villager death was.");
                    _currentExecutingLine++;
                    break;
            }
        }

        private void Prologue55()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You arrive at the village stables.\nNothing seems out of the ordinary.\n" +
                "Lots of horses, hay and the occassional farmer.");
            _currentExecutingLine++;
        }

        private void Prologue56()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You notice, however that there is a faint trail of dried blood on the ground.\n" +
                "Curious, you begin to follow it as it leads you outside the village.");
            _currentExecutingLine++;
        }

        private void Prologue57()
        {
            SetBackgroundImage("14.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The trail leads you deeper and deeper into the forest.\n" +
                "Eventually, the trail ends as you reach a large oak tree.");
            _currentExecutingLine++;
        }

        private void Prologue58()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The trail leads you deeper and deeper into the forest.\n" +
                "Eventually, the trail ends as you reach a large oak tree.\n" +
                "Everything seems to be very still, but somehow you feel uneasy.");
            _currentExecutingLine++;
        }

        private void Prologue59()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("ROAR!");
            _currentExecutingLine++;
        }

        private void Prologue60()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Suddenly a behemoth of crashs down in front of you.\n" +
                "In it's jaws appears to be the leftover villager shirt of an unfortunate victim.");
            _currentExecutingLine++;
        }

        private void Prologue61()
        {
            SetChoiceButtons(new Choices("Slash it with your sword.", "Stab it with your sword.", "Attempt to run away.", "Stay on the defensive."));
            PrintTextDialogue("The beast must've used one of the villager's bodies to draw you here. \n" +
                "You're surprised it it's intelligence, but quickly draw your sword to defend yourself.");
            _currentExecutingLine++;
        }

        private void Prologue62()
        {
        }

        private void Prologue63()
        {
        }

        private void Prologue64()
        {
        }

        private void Prologue65()
        {
        }

        private void Prologue66()
        {
        }
    }
}