using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masinytes
{
    public class GreitaMasina : Masina
    {
        //kuom musu greitamasina pranasesne? Pas ja maxgreitis 3 didesnis, stabdymo kelias dvigubai geresnis.
        public GreitaMasina(String pavadinimas) : base(pavadinimas)
        {
            //mums reikia pakeisti maxGreiti,kurio mes nematom nes yra uzdeta private ir set nera. Taigi vietoj private mes pakeiciam
            // matomuma i protected aisku masina klasej
            this.maxGreitis = 400;
        }
        public void gazuok(int kiek)
        {
            this.greitis += kiek*3;
            //neturi virsyti 200 km/h
            if (this.greitis > this.maxGreitis)
            {
                this.greitis = maxGreitis;
            }
        }
        public void stabdyk(int kiek)
        {
            this.greitis -= kiek*2;
            //neturi 
            if (this.greitis < 0)
            {
                this.greitis = 0;
            }
        }
    }
}
