using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Tutorial
    {
        public void menu()
        {

            bool gooddata = false;          //used to create a loop
            Pack call = new Pack();

            string choice;      //saves users responce in menu 
            do                 //a menu that will loop until the user enters exit
            {
                Console.Clear();            //used to make the program much nicer to use
                Console.WriteLine("1. an explanation on how the program works");
                Console.WriteLine("2. do maths based on 3 cards");
                Console.WriteLine("3. exit program");
                choice = Console.ReadLine().ToUpper();           //this will save the responce to what was entered into the menu 
                switch (choice)
                {
                    case "1":
                        Pack.ShuffleCardPack(1);
                        instructions();
                        Console.Clear();
                        break;
                    case "2":
                        Pack.ShuffleCardPack(3);
                        //dealing();
                        gooddata = true;
                        Console.Clear();
                        break;
                    case "3":
                        gooddata = true;
                        Console.Clear();
                        break;
                }

            } while (gooddata == false);
        }


        public void instructions()
        {
            Console.Clear();
            Console.WriteLine("How to operate this program");
            Console.WriteLine("");
            Console.WriteLine("If you select the option to do math based on 3 cards");
            Console.WriteLine("what will happen three random cards will be drawn");
            Console.WriteLine("the first and third card will be the numbers you have");
            Console.WriteLine("to complete a operation on depending on the second card");
            Console.WriteLine("if the second card is a spade it will be additon");
            Console.WriteLine("if the second card is a diamond it will be subtraction");
            Console.WriteLine("if the second card is a club it will be multiplication");
            Console.WriteLine("if the second card is a heart it will be division");
            Console.WriteLine("you must then correctly awnswer the question");
            Console.WriteLine("if you answer wrong you have to try again if correct");
            Console.WriteLine("you can either try with new cards or end the program");
            Console.ReadKey();
        }







        /*

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

           */
    }
           
}

