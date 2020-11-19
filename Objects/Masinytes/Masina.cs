using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masinytes
{
    public class Masina
    {
        private String pavadinimas;
        protected int greitis;
        private int kelias;
        protected int maxGreitis;

        public string Pavadinimas { get => pavadinimas; }
        public int Greitis { get => greitis;}
        public int Kelias { get => kelias;}
        //public int MaxGreitis { get => maxGreitis;}
        

        public Masina (String pavadinimas)
        {
            this.pavadinimas = pavadinimas;
            this.greitis = 0;
            this.kelias = 0;
            this.maxGreitis = 200;
        }

        public void gazuok(int kiek)
        {
            this.greitis += kiek;
            //neturi virsyti 200 km/h
            if (this.greitis > this.maxGreitis) 
            {
                this.greitis = maxGreitis;            
            }
        }
        public void stabdyk(int kiek)
        {
            this.greitis -= kiek;
            
            if (this.greitis < 0 )
            {
                this.greitis = 0;
            }
        }
        public void vaziuok()
        {
            kelias += greitis;
        }

        public String toString()
        {
            return "Masina : pavadinimas(" + this.pavadinimas + "), greitis (" + this.greitis + "),kelias(" + this.kelias + "), maxGreitis (" + this.maxGreitis + ")";
        }

    }
}
