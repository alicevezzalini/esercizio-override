using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esercizio_override
{
    internal class Cerchio
    {
        public int Raggio { get; set; }

        public override string ToString()
        {
            return string.Format("{0}", Raggio);
        }
    }
}
