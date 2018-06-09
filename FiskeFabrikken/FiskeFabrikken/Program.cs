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
            Fabrik fabrikke = new Fabrik();
        }
    }
    class Fabrik
    {
        private List<Fisk> fiskeListe = new List<Fisk>();
        //OPGAVE til Jákup. 
        //Lav en construktør som insætter 10 fisk ind i fiskeListe.
    }
    class Fisk
    {
        private int weight;
        //OPGAVE til Hans Olivur.
        //Lav en construktør som sætter weight til en værdi som kommer udefra.
        //Lav også en set get til weight.
    }
}
