using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the program");
            Console.ReadKey();
            Tutorial practic= new Tutorial();
            practic.menu();
            Console.WriteLine("Goodbye thank you for using our program");
            Console.ReadKey();
        }
    }
}
