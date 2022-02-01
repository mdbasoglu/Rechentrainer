using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechentrainer
{
    internal class Multiplikationsquiz
    {
        private int zahl1;
        private int zahl2;

        public int Zahl1 { get => zahl1; set => zahl1 = value; }
        public int Zahl2 { get => zahl2; set => zahl2 = value; }
        

        public Multiplikationsquiz(int zahl1, int zahl2)
        {
            Zahl1 = zahl1;
            Zahl2 = zahl2;  
        }

        public Multiplikationsquiz()
        {
        }

        public int aaaaaaaa() 
        {
            Random rastgele = new Random();
            Zahl1 = rastgele.Next(1, 21);
            Zahl2 = rastgele.Next(1, 21);
            return Zahl1 * Zahl2;
        }

        public override string ToString()
        {
            return $"{Zahl1} * {Zahl2} = ?";
        }
    }
}
