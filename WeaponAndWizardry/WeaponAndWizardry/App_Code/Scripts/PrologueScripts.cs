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

            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Where am I…?\"\nA soft light fills the area," +
                "giving the atmosphere a solemn feel.\n ... \"Is this a dream?\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue2()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Oh brave hero…\"\nYou hear a beautiful voice begin to call you.\n"
                + "The great goddess Ilias suddenly appears before you.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue3()
        {
            SetChoiceButtons(new Choices("\"I can!\"", "\"Nope.\"", "\"...\""));
            PrintTextDialogue("\"Oh great hero… can you hear my voice?\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue4()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You begin to tremble at the sound of Ilias‘s voice.\n" +
                "The goddess whom created the world, who extends her love to humanity.\n" +
                "You feel both relaxed and awed with such an amazing figure before you.\n" +
                "Even if it’s just a dream.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue5()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"I have forseen that you will be the deciding factor"
                + "in bringing harmony or calamity to men and beast alike.\n" +
                "Whether your destiny leads to that of rightous paragon or" +
                "a ruthless renagede. I am here to help guide you, so that " +
                "you may live up to your full potential.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue6()
        {
            SetChoiceButtons(new Choices("\"I'm the strongest there is.(Strength++)\"", "\"Speed's my game.(Dexterity++)\"",
                "\"I know everything.(Intelligence++)\"", "\"I've always been very lucky (Luck++)\""));
            PrintTextDialogue("\"Before we begin, I want to know more about you, oh great hero.\n" +
                "How would you describe yourself?\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue7()
        {
            SetChoiceButtons(new Choices("\"I'm not very strong...(Strength--)\"", "\"I'm a little slow (Dexterity--)\"",
                "\"I've never been very bright.(Intelligence--)\"", "\"I'm super unlucky.(Luck--)\""));
            PrintTextDialogue("\"What would you say is your biggest weakness?\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue8()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("More text added here for tutorial\n\n");
            _currentExecutingLine++;
        }

        //More dialogue here?

        private void Prologue9()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Farewell, brave hero.\n  Know that I will always be watching over you, " +
                "even in the tutorial section.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue10()
        {
            ClearImageDisplay();
            SetBackgroundImage("13.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You suddenly wake up to see the camp you made last night.\n" +
                "A dream about Illias.\n \"I wonder what sort of great destiny " +
                "I could possibly have.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue11()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You check around your camp belongings as you ponder your thoughts. \n" +
                "Your possessions include: your sword, a monster" +
                "slaying contract and typical camping necessities.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue12()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You open the contract scroll among your belongings.\n" +
                "\"Contract: Slay the beast of Granberia.\n Reward will be given by Granberia's village chief.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue13()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You recall that you camped near the Granberia city to hopefully slay the beast " +
                "and collect the bounty." +
                "\nTo make ends meet, you took up your sword and began slaying monsters for a living for a couple years now." +
                "\"Man’s gotta eat after all.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue14()
        {
            SetBackgroundImage("11.png");
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You make your way along the road to the city of Granberia.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue15()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"HELP ME!\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue16()
        {
            SetChoiceButtons(new Choices("Rush over to find out who's calling for help", "Ignore it"));
            PrintTextDialogue("You hear someone shouting nearby\n\n");
            _currentExecutingLine++;
        }

        private void Prologue17()
        {
            SetChoiceButtons(new Choices("Attempt to rescue the soldier", "Ignore"));
            PrintTextDialogue("You rush over and see a soldier tied up, being attacked by goblins.\n" +
                "What do you do?\n\n");
            _currentExecutingLine++;
        }

        private void Prologue18()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You rush over with your sword in hand.The goblins are alerted to your presence.\n"
                + "\"KREEE!KREEE!\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue19()
        {
            SetChoiceButtons(new Choices("Attack with your sword", "Flee", "Intimidate them with a battle-cry (Strength)"));
            PrintTextDialogue("You’re outnumbered 3-to-1.  However, you know that goblins are generally cowards" +
                " and will flee if they think the odds are against them.\n  What do you do?\n\n");
            _currentExecutingLine++;
        }

        private void Prologue20()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You’ve decided that the incident was more trouble than it’s worth.\n" +
                "You continue on your way towards Granberia. \n\n");
            _currentExecutingLine++;
        }

        private void Prologue21()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("With your sword in hand, you attempt to slice the biggest goblin in two.\n" +
            "However, you swing doesn’t go clean through and the goblin is able to retaliate \n\n");
            _currentExecutingLine++;
        }

        private void Prologue22()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The goblin is now badly wounded and is open " +
                "for your next attack which cleaves the goblin in two.\n  \"KREEE!Kree... \"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue23()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("The big goblin goes crashing down.  His two companions now fear stricken," +
                "flee for their lives.  \nTired from the ordeal, you decide not to give chase.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue24()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide the best course of action would be to bluff your way to victory.\n" +
            "You bellow a battle cry with all your might.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue25()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"COME FORTH YOU SHALL FIND NO HONOUR IN DEATH!\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue26()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Your cry succeeds in intimidating the three goblins.\n" +
                "They all look to each other in fear and run away.\n" +
                "You decide not pursue them since you’ve already won the battle.\n" +
                "\"That was some shout,\" you hear the soldier comment.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue27()
        {
            SetChoiceButtons(new Choices("Untie him", "Ask him why he’s tied up", "Leave him to the monsters",
                "Kill him and loot him"));
            PrintTextDialogue("\"Thank you.  My name is John Verdan.  Now quick, untie me!  More of those things could appear\"\n" +
                "The tied up soldier is now asking for your assistance.  His fate is in your hands.\n" +
                "What do you do?\n\n");
            _currentExecutingLine++;
        }

        private void Prologue28()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to untie the ropes around the soldier's arms and legs. \n" +
                "\"Thanks. Now, I’m gonna get out of here before more of those goblins show up. " +
                "\nI promise I’ll pay you back someday.The soldier rushs away, quick to leave the area.\"\n\n"
            );
            _currentExecutingLine++;
        }

        private void Prologue29()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to continue onwards with your journey.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue30()
        {
            SetChoiceButtons(new Choices("\"No\"", "\"Fine, fine.  I'll untie you.\""));
            PrintTextDialogue("\"What? Can’t you just untie me first?\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue31()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"But I… Ugh, okay fine.  I’m tied up because I’m a deserter.\n" +
                "I left the army because I’m a coward who doesn’t want to die.  \n" +
                "With so much political instability, nations aren’t so keen on sharing at the moment.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue32()
        {
            SetChoiceButtons(new Choices("Untie him", "Leave him to the monsters", "Kill him and loot him"));
            PrintTextDialogue("\"I’m not that nationalistic, but I needed money to buy food to survive.  \n" +
            "It’s hard making a living in this day and age.  I joined the army to make ends meet, but… well you know.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue33()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You decide to leave the soldier tied up as you begin to leave." +
                "\n \"What? Hey, you can't leave me here! Please, please don't let me die! I don't wanna die!" +
                "Despite the soldier's cries, you leave and continue on your journey.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue34()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You slowly walk around the tired up soldier, inspecting him from behind.\n" +
                "\"So... how about it? Free me please?\"\n " +
                "You raise your sword and aim for a quick execution-style cut. \n" +  
                "\"What the - !What are you doing ? I…-\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue35()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You swing your sword and decapitate the soldier.\n" + 
                "The soldier's head comes clean off and his body lands lifeless on the floor.\n" +
                "Unmoved by your recent murder, you search the soldier's body for loot.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue36()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Unsurprisingly, the body has nothing of value.\n You decide to continue on your journey. \n\n");
            _currentExecutingLine++;
        }

        private void Prologue37()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You finally arrive in Granberia.  The town is decently sized compared to your expectations.\n" +
                "The town seemed to contain no more than 100 citizens and they ranged from children to the elderly.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue38()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("You begin exploring the village and eventually spot the village chief's house. \n" +
                "The door isn't locked, so you let yourself in.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue39()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("Upon entering, you meant a very elderly man. \n" +
                "He seemed a little anxious from his pacing back and forth. \n\n");
            _currentExecutingLine++;
        }

        private void Prologue40()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Ah, you must be a slayer who accepted the contract.  I can tell from your monster-slaying medallion.\n" +
            "\"Please have a seat.\" \nThe old man motions to a seat before him. \n\"My name is \n\n");
            _currentExecutingLine++;
        }

        private void Prologue41()
        {
            SetChoiceButtons(new Choices("\"Double the reward or I walk, old man.\"", "\"I accept the contract.\""));
            PrintTextDialogue("\"As you know, our village is currently being attacked by an unknown monster.\n"+
                "It seems to happen at random times.  The most recent attack was near the stables of our village.\n"+
                "Please I beg you to help us.\n  The reward of 500 gold pieces.  \n\n");
            _currentExecutingLine++;
        }

        private void Prologue42()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"D-Double?!? But I... The village...\"\n The village chief sighs.\n "+
                "\"If it will save our village, I will pay any price.\n You have a deal.\"\n\n");
            _currentExecutingLine++;
        }

        private void Prologue43()
        {
            SetChoiceButtons(new Choices("\"Fine, I'll do the deed for 500 gold.\""));
            PrintTextDialogue("\"D-Double?!? That's outragous. \nI could hire 10 mercenaries for that kind "+
                "of money.  \nNo deal.\" \nThe old man looks sternly back at you.  It's unlikely he will change his mind.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue44()
        {
            SetChoiceButtons(nextChoice);
            PrintTextDialogue("\"Very good.  \nPlease slay the beast and bring me it's head as proof.  " +
                "\nOnly then will you be paid.\" The old man motions you to leave as he has other matters to attend to.\n\n");
            _currentExecutingLine++;
        }

        private void Prologue45()
        {
            SetChoiceButtons(new Choices("Ask around the village", "Go to the most recent murder scene"));
            PrintTextDialogue("With the deal set, you leave the village chief's house.\n"+
                "You need to somehow find and slay the beast that's been kill all the villagers.\n What do you do?\n\n");
            _currentExecutingLine++;
        }

        private void Line99()
        {
            ClearImageDisplay();
            SetBackgroundImage("original.jpg");
            AddForegroundImage("images/Neet.jpg", 400, 300, 12, 120, 120);
            switch (_choicePicked)
            {
                case 1:
                    PrintTextDialogue("You attack!");
                    break;
                case 2:
                    PrintTextDialogue("You Run!");
                    break;
            }
            SetChoiceButtons(new Choices("Fight More", "Run more"));
            _currentExecutingLine++;
        }

        private void Line100()
        {
            ClearImageDisplay();
            SetBackgroundImage("original.jpg");
            AddForegroundImage("images/Shiki.png", 400, 300, 12, 120, 120);
            switch (_choicePicked)
            {
                case 1:
                    SetChoiceButtons(new Choices());
                    PrintTextDialogue("You Die!");
                    break;
                case 2:
                    SetChoiceButtons(new Choices());
                    PrintTextDialogue("You Slip!");
                    break;
            }
            _currentExecutingLine++;
        }

    }
}