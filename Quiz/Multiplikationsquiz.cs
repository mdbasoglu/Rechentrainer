using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Multiplikationsquiz
    {

        private int _faktor1;

        public int _Faktor1
        {
            get { return _faktor1; }
            set {_faktor1 = value; }
        }

        private int _faktor2;

        public int _Faktor2
        {
            get { return _faktor2; }
            set {_faktor2 = value; }
        }

        public string Frage
        {
            get { return $"{_Faktor1} * {_Faktor2} = ?"; }
        }

        public int Antwort
        {
            get { return _Faktor1 * _Faktor2; }
        }

        public Multiplikationsquiz()
        {
            Random random = new Random();
            _Faktor1 = random.Next(1, 21);
            _Faktor2 = random.Next(1, 21);
        }
    }
}
