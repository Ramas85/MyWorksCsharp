using System;

namespace Objects
{
    public class Termosas : Puodukas
    {
        public int temp;
        public Termosas(int turis) : base('M', turis)
        {
            temp = 20;
        }

        public void pasildyk(int t)
        {
            temp += t;
            if (temp > 100)
            {
                temp = 100;
                Console.WriteLine("Temperatura yra parinkta per auksta. Max gali buti 100,temperatura paliekam - " + temp);
            }
        }

        public void atsaldyk(int t)
        {
            temp -= t;
        }

        /* public void ipilk(int kiek) : base.ipilk 
         {

         }
     }  
        */
    }
}
