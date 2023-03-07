using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        public void testing()
        {
            bool gooddata = false;          //used to create a loop
            Pack call = new Pack();
            
            string choice;      //saves users responce in menu 
            do                 //a menu that will loop until the user enters exit
            {
                Console.Clear();            //used to make the program much nicer to use
                Console.WriteLine("1. do no type of shuffle");
                Console.WriteLine("2. do a Fisher–Yates shuffle");
                Console.WriteLine("3. do a Riffle shuffle");
                Console.WriteLine("4. exit program");
                choice = Console.ReadLine().ToUpper();           //this will save the responce to what was entered into the menu 
                switch (choice)
                {
                    case "1":
                        Pack.ShuffleCardPack(1);
                        dealing();
                        gooddata = true;
                        Console.Clear();
                        break;
                    case "2":
                        Pack.ShuffleCardPack(2);
                        dealing();
                        gooddata = true;
                        Console.Clear();
                        break;
                    case "3":
                        Pack.ShuffleCardPack(3);
                        dealing();
                        gooddata = true;
                        Console.Clear();
                        break;
                    case "4":
                        gooddata = true;
                        Console.Clear();
                        break;
                }
                
            } while (gooddata == false);
        }

        public void dealing() 
        {
            bool gooddata = false;          //used to create a loop
            Pack call = new Pack();

            string choice;      //saves users responce in menu 
            do                 //a menu that will loop until the user enters exit
            {
               
                Console.WriteLine("1. deal one card");
                Console.WriteLine("2. deal a specific amount of cards");
                Console.WriteLine("3. exit program");
                choice = Console.ReadLine().ToUpper();           //this will save the responce to what was entered into the menu 
                switch (choice)
                {
                    case "1":
                        Pack.deal();
                        
                        break;
                    case "2":
                        int amm = 0;
                        try
                        {
                            Console.WriteLine("how many cards would you like to deal?");
                            amm = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("what you entered was not a number try again");
                        }
                        Pack.dealCard(amm);
                        break;
                    case "3":
                        gooddata = true;
                        Console.Clear();
                        break;
                }

            } while (gooddata == false);


        }
    }
}
