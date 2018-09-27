using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string tekst;
            DateTime dt = DateTime.Now;
            bool b = true;
            
                Console.WriteLine("Napisz cos");
                tekst = Console.ReadLine();

                for (int i = 0; i < tekst.Length; i++)
                {
                    

                    if (Char.IsDigit(tekst[i]))
                    {
                        Console.WriteLine("I'm not calculator");
                        b = false;
                    }
                        

                }

                if (tekst == "Data"|| tekst == "data")
                    Console.WriteLine(dt);
                else if (b != false)
                    Console.WriteLine("Hi!");


            Console.ReadKey();
        }
    }
}
