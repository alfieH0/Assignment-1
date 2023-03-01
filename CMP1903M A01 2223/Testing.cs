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
            Card call2 = new Card(0);
            string choice;      //saves users responce in menu 
            do                 //a menu that will loop until the user enters exit
            {
                Console.Clear();            //used to make the program much nicer to use
                Console.WriteLine("A: ");
                choice = Console.ReadLine().ToUpper();           //this will save the responce to what was entered into the menu 
                switch (choice)
                {
                    case "A":
                        call.
                        gooddata = true;
                        Console.Clear();
                        break;
                }
                
            } while (gooddata == false);
        }
    }
}
