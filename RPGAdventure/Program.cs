// See https://aka.ms/new-console-template for more information

namespace AdventureRPG {

    public static class Game {

        //name of character
        static string CharacterName = "Player 1";

        //print game title
        public static void StartGame()
        {
            Console.WriteLine("Dungeon Crawler");
            Console.WriteLine("Hello, you seem like you are ready for an adventure.");
            NameCharacter();
        }
        //player name input 
        static void NameCharacter()
        {
            Console.WriteLine("What's your name? ");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Hmm... " + CharacterName + "... What a strange name.");
        }
        static void Dialog(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }

    class Item { }

    class Program {
        static void Main()
        {
            Game.StartGame();
            Console.ReadKey();
        }
            }
    }