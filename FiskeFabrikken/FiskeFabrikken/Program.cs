using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiskeFabrikken
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeg er en fiskefabrik");
        }
    }
    class Fabrik
    {
        List<Fisk> fiskeListe = new List<Fisk>();
    }
    class Fisk
    {
        public String type;
    }
}
