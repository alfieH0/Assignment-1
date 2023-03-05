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


        List<Card> pack = new List<Card>();
        List<Card> shuffled = new List<Card>();

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
                case 0:
                    call.FillDeck();
                    break;
                case 1:
                    call.FillDeck();
                    call.FYShuffle();
                    break;//does one of the shuffle types 
            }
        }
        public static Card deal()
        {
            bool GoodData = true;
            var call = new Pack();
            do
            {
                foreach (Card card in call.pack)
                {
                    Console.WriteLine(card.CardName);
                    GoodData = false;


                }
            } while (GoodData == true);
            return null;
        }
        public static List<Card> dealCard(int amount)
        {
            var call = new Pack();
            int i = 0;
            if (i <= amount)
            {
                foreach (Card card in call.pack)
                {
                    Console.WriteLine(card.CardName);
                }
            }
            return null;
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
        public static void RiffleShuffleDeck()
        {
            var call = new Pack();
            Random rand = new Random();
            List<Card> RifShuffled = new List<Card>();
            int n = call.pack.Count / 2;
            int k = rand.Next(n);
            int j = n + rand.Next(n);

            for (int i = 0; i < call.pack.Count; i++)
            {
                if (k == 0 && j == call.pack.Count)
                {
                    k = rand.Next(n);
                    j = n + rand.Next(n);
                }

                if (k > 0)
                {
                    RifShuffled[i] = call.pack[(i % 2 == 0) ? k-- - 1 : j++ - 1];
                }
                else
                {
                    RifShuffled[i] = call.pack[(i % 2 == 0) ? j++ - 1 : k-- - 1];
                }
                call.pack = RifShuffled;
            }
        }
    }
}
