
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechentrainer
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Multiplikationsquiz multiplikationsquiz = new Multiplikationsquiz();
            
            int antwort= multiplikationsquiz.aaaaaaaa();

            Console.WriteLine(multiplikationsquiz);
            Console.WriteLine($"Antwort: {antwort}");

            Console.ReadKey();
        }
    }

}


