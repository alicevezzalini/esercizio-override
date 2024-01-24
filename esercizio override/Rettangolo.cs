using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_override
{
    internal class Rettangolo
    {
        public int Lato1 { get; set; }
        public int Lato2 { get; set; }

        public override string ToString()
        {
            return string.Format("{0} {1}", Lato1, Lato2);
        }


    }
}
