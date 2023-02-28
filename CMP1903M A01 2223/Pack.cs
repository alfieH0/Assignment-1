using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        
        List<Card> pack;

        public Pack()
        {
            
        }
        
        public static bool ShuffleCardPack(int typeOfShuffle)
        {
            switch(typeOfShuffle) 
            {
                case 0:
                    deal();
                    return false;
                case 1:
                    return true;//does one of the shuffle types 
            }
            
            

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
        }
        
    }
}
