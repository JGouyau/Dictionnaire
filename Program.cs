using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionnaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> monPremierDico = new Dictionary<char, string>();
            monPremierDico['a'] = "machin";
            monPremierDico['b'] = "truc";
            monPremierDico['c'] = "bidul";

            Console.WriteLine(monPremierDico.Count());

            Console.ReadKey();

            monPremierDico.Remove('c');

            Console.WriteLine(monPremierDico.Count());

            Console.ReadKey();
        }
    }
}
