using System;
using System.Collections.Generic;
using static System.Random;
using System.Text;

namespace Emoman
{
    class Program
    {


                    private static void Hangman(int wrong){
            if (wrong == 0)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");
            }
            else if (wrong == 1)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");



            }
            else if (wrong == 2)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");

            }
            else if (wrong == 3)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               0                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");

            }
            else if (wrong == 4)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               0                 |");
                Console.WriteLine("|              /|?                |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");
            }
            else if (wrong == 5)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               0                 |");
                Console.WriteLine("|              /|?                |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|                                 |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");
            }
            else if (wrong == 6)
            {
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|             HANG MAN            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|               0                 |");
                Console.WriteLine("|              /|?                |");
                Console.WriteLine("|               |                 |");
                Console.WriteLine("|              / ?                |");
                Console.WriteLine("|         +----------+            |");
                Console.WriteLine("|         |          |            |");
                Console.WriteLine("+---------------------------------+");
                Console.WriteLine("|         Guess the word          |");
                Console.WriteLine("+---------------------------------+");
            }
        }

        private static int PrintWord(List<char> guessedletter, String randomWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach (char c in randomWord)
            {
                if(guessedletter.Contains(c))
                {
                    Console.WriteLine(c + " ");
                    rightLetters++;
                }
                else
                {
                    Console.Write(" ");
                }
                counter++;
            }
            return rightLetters;
        }
        private static void PrintLines(String randomWword)
        {
            Console.Write("\r");
            NewMethod(randomWword);
        }

        private static void NewMethod(string randomWord)
        {
            foreach (char c in randomWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305");
            }
        }
        
        //undersekves och lista
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to hangman :)");
            Console.WriteLine("----------------------------------------");

            Random random = new Random();
            //Här är våra listor.
            List<string> wordDictionary = new List<string> {"House", "diamond", "sunflower", "space", "funny", "boobs", "sajeel", "Sun", "beautiful" };
            int index = random.Next(wordDictionary.Count);
            string randomWord = wordDictionary[index];

            foreach (char x in randomWord)
            {
                Console.Write("_ ");
            }
            int Lenghtofword = randomWord.Length;
            int WrongGuesses = 0;
            List<char> CorrectGuesses = new List<char>();
            int CorrectLetters = 0;

            while (WrongGuesses != 6 && CorrectLetters != Lenghtofword)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach(char letter in CorrectGuesses)
                {
                    Console.Write(letter + " ");
                }
                // frågar för input från användare
                Console.Write("\nGuess a letter: ");
                char letterGuessed = Console.ReadLine()[0];
                // checkar om användare har gissat rätt
                if(CorrectGuesses.Contains(letterGuessed))
                {
                    Console.Write("\r\nYou have guessed this letter.");
                    Hangman(WrongGuesses);
                    CorrectGuesses = PrintWord(CorrectGuesses, randomWord);
                    PrintLines(randomWord);
                }
                else
                {
                    //checkar om bokstaven är i meningen
                    bool right = false;
                    for (int i = 0; i < randomWord.Length; i++) { if(letterGuessed == randomWord[i]) { right = true; } 

                    if(right)
                        {
                            Hangman(WrongGuesses);
                            CorrectGuesses.Add(letterGuessed);
                            CorrectLetters = PrintWord(CorrectGuesses, randomWord);
                            Console.Write("\r\n");
                            PrintLines(randomWord);
                        }
                        else
                        {
                            WrongGuesses++;
                            letterGuessed.Add(letterGuessed);
                            Hangman(WrongGuesses);
                            CorrectGuesses = PrintWord(letterGuessed, randomWord);
                            Console.Write("\r\n");
                            PrintLines(randomWord);
                        }
                }
                
            }
                Console.WriteLine("\r\nGame Over! Thank You For Playing");
        }

    }
}
