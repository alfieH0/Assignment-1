using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
  
    
    public class Card
    {
        public enum Suits    //makes these pre defined constants    
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public Suits Suit { get; set; }

        public Card(int Value, Suits Suit)
        {
            this.Value = Value;
            this.Suit = Suit;
        }

        public string SpecialCards
        {
            get
            {
                string name = string.Empty;     //sets the specific numbers to allways to represented by these strings 
                switch (Value)
                {
                    case (1):
                        name = "Ace";
                        break;
                    case (13):
                        name = "King";
                        break;
                    case (12):
                        name = "Queen";
                        break;
                    case (11):
                        name = "Jack";
                        break;
                    default:
                        name = Value.ToString();
                        break;
                }

                return name;
            }
        }
        public string CardName  //will print the card number and suit when called 
        {
            get
            {
                return SpecialCards + " of " + Suit.ToString();
            }
        }
    }
    
}
    

