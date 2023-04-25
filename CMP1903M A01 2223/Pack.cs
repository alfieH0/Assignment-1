﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {

        private static List<Card> pack = new List<Card>();

        public void FillDeck()
        {
            //Can use a single loop utilising the mod operator % and Math.Floor
            //Using divition based on 13 cards in a suited
            for (int i = 0; i < 52; i++)
            {
                Card.Suits suit = (Card.Suits)(Math.Floor((decimal)i / 13));
                int num1 = i % 13 + 2;
                if (num1 == 14) // check if it's an Ace
                {
                    num1 = 1; // set the value of Ace to 1
                }
                pack.Add(new Card(num1, suit));
            }
        }

        public static bool ShuffleCardPack(int typeOfShuffle)   //based on user input will fill the deck then shuffle the deck if required 
        {
            var call = new Pack();
            call.FillDeck();
            switch (typeOfShuffle)
            {
                case 1:
                    break;
                case 2:
                    call.FYShuffle();
                    break;
            }
            return true;
        }
        public void ThreeCard()         //error where if you press enter it will escape from while loop plus need error testing
        {
            try
            {
                if (pack[1].Suit == Card.Suits.Spades)
                    {
                    int num1 = int.Parse(pack[0].SpecialCards);
                    int num2 = int.Parse(pack[2].SpecialCards);
                    int CorrectAns = num1 + num2;
                    bool correct = false;
                    do
                    {
                        Console.WriteLine("what is {0} + {1}", num1, num2);
                        int UserAns = int.Parse(Console.ReadLine());

                        // Compare user input to correct answer
                        if (UserAns == CorrectAns)
                        {
                            Console.WriteLine("Correct!");
                            Console.ReadLine();
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect. Try again.");
                            Console.ReadLine();
                        }
                    } while (!correct);
                    }
                else if (pack[1].Suit == Card.Suits.Diamonds)
                {
                    int num1 = int.Parse(pack[0].SpecialCards);
                    int num2 = int.Parse(pack[2].SpecialCards);
                    int CorrectAns = num1 - num2;
                    bool correct = false;
                    do
                    {
                        Console.WriteLine("what is {0} - {1}", num1, num2);
                        int UserAns = int.Parse(Console.ReadLine());

                        // Compare user input to correct answer
                        if (UserAns == CorrectAns)
                        {
                            Console.WriteLine("Correct!");
                            Console.ReadLine();

                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect. Try again.");
                            Console.ReadLine();
                        }
                    } while (!correct);
                }
                else if (pack[1].Suit == Card.Suits.Clubs)
                {
                    int num1 = int.Parse(pack[0].SpecialCards);
                    int num2 = int.Parse(pack[2].SpecialCards);
                    int CorrectAns = num1 * num2;
                    bool correct = false;
                    do
                    {
                        Console.WriteLine("what is {0} * {1}", num1, num2);
                        int UserAns = int.Parse(Console.ReadLine());

                        // Compare user input to correct answer
                        if (UserAns == CorrectAns)
                        {
                            Console.WriteLine("Correct!");
                            Console.ReadLine();
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect. Try again.");
                            Console.ReadLine();

                        }
                    } while (!correct);
                }
                else if (pack[1].Suit == Card.Suits.Hearts)
                {
                    decimal num1 = decimal.Parse(pack[0].SpecialCards);
                    decimal num2 = decimal.Parse(pack[2].SpecialCards);
                    decimal CorrectAns = Math.Round(num1/num2, 2);
                    bool correct = false;
                    do
                    {
                        Console.WriteLine("what is {0} / {1}", num1, num2);
                        Console.WriteLine("round to 2 decimal places when applicable");
                        decimal UserAns = decimal.Parse(Console.ReadLine());

                        // Compare user input to correct answer
                        if (UserAns == CorrectAns)
                        {
                            Console.WriteLine("Correct!");
                            Console.ReadLine();
                            correct = true;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect. Try again.");
                            Console.ReadLine();

                        }
                    } while (!correct);
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("what you entered was not a number try again");
                ThreeCard();
            }
        }
        public void FYShuffle()         //Fisher-Yates Shuffle the deck of cards 
        {
            Random rng = new Random();

            for (int i = pack.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                Card temp = pack[i];
                pack[i] = pack[j];
                pack[j] = temp;
            }
        }
    }
}

