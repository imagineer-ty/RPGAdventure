// See https://aka.ms/new-console-template for more information

namespace AdventureRPG {

    class Program {
        static void Main()
        {
            string CharacterName = "Player 1";

            Console.WriteLine("Dungeon Crawler");
            Console.WriteLine("Hello, you seem like you are ready for an adventure.");
            Console.WriteLine("What's your name? ");
            CharacterName = Console.ReadLine();
            Console.WriteLine("Hmm... " + CharacterName + "... What a strange name." );

            Console.ReadKey();
        }
            }
    }