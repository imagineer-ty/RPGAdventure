// See https://aka.ms/new-console-template for more information

namespace AdventureRPG {

    public static class Game {

        //name of character
        static string CharacterName = "Player 1";

        //print game title
        public static void StartGame()
        {
            Console.WriteLine("Dungeon Crawler");
            Dialog("Hey you, where'd you come from?");
            NameCharacter();
            Choice();
        }
        //player name input 
        static void NameCharacter()
        {
            Dialog("What's your name? ");
            CharacterName = Console.ReadLine();
            Dialog("Hmm... " + CharacterName + "... What a strange name.");
            Narration("A small bug lands on your shoulder");
            Dialog("\nHey, " + CharacterName + "... You should probably kill that bug on your shoulder");
            Decision("What's your immediate action? \nA) Kill the bug, \nB) Let the bug return to its family");
        }

        //these next methods will change the color of the text based on the action that is happening 
        //dialog text is blue
        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();

            //Console.Write("A small bug lands on your shoulder");
            //Dialog("Hey, " + CharacterName + ", you should probably kill that bug on your shoulder");
            //Console.Write("What's your immediate action? A) Kill the bug, B) Let the bug return to its family");
           
        }
        //narration text is yellow
        static void Narration(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine(message);
            Console.ResetColor();
        }
        //decision text carries the story, text turns red 
        static void Decision(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //first choice in game 
        static void Choice()
        {
            string input = "";
            Decision("\n"+CharacterName + ", Which will you choose? A or B ");
            input = Console.ReadLine();
            if(input == "B")
            {
                Narration("The bug makes its way to your neck. You can feel its sharp little feet " +
                                  "\nprickling you on the way, unsure if any blood is being drawn. It bites your neck.\n" +
                                  "In immense pain, you drop to the floor and your heart stops beating.");
                Dialog(CharacterName + "! HEY! WAKE UP, WAKE U-");
            } 
            else if (input == "A")
            {
                Narration("You smack the bug on your shoulder and it starts glowing. Theres a loud explosion in the distance.\n" +
                                  "As you look back to see where it came from you are warped into an unfamiliar area.");
            } else
            {
                Console.WriteLine("Invalid option. Try again.");
                Choice();
            }
        }
    }

    class Item { }

    class Program {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }
            }
    }