﻿// See https://aka.ms/new-console-template for more information

/*Notes for what will be worked on next:
 *Check Choice() method and go through switch case - section may need to be removed for if/else until more options for character 
 * 
 * work to separate classes into different files, call them from main class in program.cs (Coming later)
 */

namespace AdventureRPG {

    public static class Game {

        static int Scenarios = 3;
        //name of character
        static string CharacterName = "Player 1";

        static string[] PartOne = { 
        "part one of the game "};

        static string[] PartTwo =
        {
        "part two of the game"
        };

        static string[] PartThree =
        {
        "part three of the game"
        };

        //print game title
        public static void StartGame()
        {
            Console.WriteLine("Dungeon Crawler");
            Dialog("Hey you, where'd you come from?");
            NameCharacter();
            Choice();
            EndGame();
        }
        
        public static void EndGame()
        {
            //end of game text
            Console.WriteLine("Your story ends here");
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

            //might take out this swtich section - may not be needed 
            switch (section)
            {
                case 1:
                    //part one
                    Console.WriteLine(PartOne[0]);

                    //read players first choice a or b
                    Console.ForegroundColor= ConsoleColor.Green;

                    Console.WriteLine("Enter your choice:");
                    input = Console.ReadLine();
                    input = input.ToLower();
                    Console.ResetColor();

                    if (input == "a")
                    {
                        Console.WriteLine(PartOne[1]);
                    } else
                    {
                        Console.WriteLine(PartOne[2]);
                    }

                    //print next part of section
                    Console.WriteLine(PartOne[3]);

                    //if a again print next, or skip ahead
                    if(input == "a")
                    {
                        Console.WriteLine(PartOne[4]);
                    } else
                    {
                        Console.WriteLine(PartOne[5]);
                    }
                    


            }

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