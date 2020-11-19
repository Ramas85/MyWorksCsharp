using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Puodukas
    {
        public char medziaga = (char)0;
        public int turis = 0;
        public int kiekis = 0;

        public Puodukas(char m, int turis)
        {
            medziaga = m;
            this.turis = turis;
            kiekis = 0;
        }
        public void ipilk (int kiek)
        {
            this.kiekis += kiek;
            if (kiekis > turis)
            {
                kiekis = turis;
            }
        }
        public void isgerk (int kiek)
        {
            this.kiekis -= kiek;
            if(kiekis < 0 )
            {
                kiekis = 0 ;
            }
        }
              public String toString()
              {
                  return "Puodukas : medziaga(" + this.medziaga + "), turis (" + this.turis + "),kiekis(" + this.kiekis + ")";
              }      
    }
}


