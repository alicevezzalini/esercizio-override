using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cerchio cerchio = new Cerchio();    
            Rettangolo rettangolo = new Rettangolo();

            cerchio.Raggio = 3;
            rettangolo.Lato1 = 2;
            rettangolo.Lato2 = 4;

            Console.WriteLine(cerchio.ToString());
            Console.WriteLine(rettangolo.ToString());

            Console.ReadLine();

        }
    }
}
