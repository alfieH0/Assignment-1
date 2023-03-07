using System;
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
                //Add 2 as a deck starts at 2
                int num1 = i % 13 + 2;
                pack.Add(new Card(num1, suit));
            }
        }

        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            var call = new Pack();
            switch (typeOfShuffle)
            {
                case 1:
                    call.FillDeck();
                    break;
                case 2:
                    call.FillDeck();
                    call.FYShuffle();
                    break;
                case 3:
                    call.FillDeck();
                    for (int i = 0; i < 7; i++)
                    {
                        call.RiffleShuffle();
                    }
                    
                    break;//does one of the shuffle types 
            }
            return true;
        }
        public static Card deal()
        {
            try
            {
                Card card = pack[0];
                Console.WriteLine(card.CardName);
                Console.ReadLine();
                pack.RemoveAt(0);
                return card;
            }
            catch (ArgumentOutOfRangeException) 
            {
                Console.WriteLine("you have run out of cards in the pack");
                return null;
            }
            
        }
        public static List<Card> dealCard(int amount)
        {
            try
            {
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine(pack[0].CardName);
                    pack.RemoveAt(0);
                }
                Console.ReadLine();
                return pack;
            }
            catch (ArgumentOutOfRangeException)
            { 
                Console.WriteLine("you have run out of cards in the pack");
                return pack;
            }
            catch (FormatException)
            {
                Console.WriteLine("what you entered was not a number try again");
                return pack;
            }
        }
        public void FYShuffle()
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
        public void RiffleShuffle()
        {

            int half = pack.Count / 2;
            List<Card> OneHalf = pack.GetRange(0, half);
            List<Card> SecHalf = pack.GetRange(half, pack.Count - half);

            pack.Clear();
            for (int i = 0; i < half; i++)
            {
                pack.Add(OneHalf[i]);
                pack.Add(SecHalf[i]);
            }
            if (SecHalf.Count > OneHalf.Count)
            {
                pack.AddRange(SecHalf.GetRange(half, SecHalf.Count - half));
            }
        }
    }
}

