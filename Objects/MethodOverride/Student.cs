using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
   public class Student : Person {  

       public Student()
        {

        }
        public  override void Work()
        {
            Console.WriteLine("Metodas, kuri jau naudosim klaseje Studentas");
        }
        public override void Work(int a)
        {
            Console.WriteLine("Metodas su parametru, kuri naudosim klaseje Studentas");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Si uzrasa parasys tiek kartu kiek perduosime parametru (Studentas)");
            }
            
        }
    }
}
