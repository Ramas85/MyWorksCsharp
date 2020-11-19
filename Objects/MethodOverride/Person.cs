using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverride
{
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person(string n, int a)
        {
            this.name = n;
            this.age = a;
        }
        public Person()
        {
        }

        public virtual void Work()
        {
            Console.WriteLine("Its method in class - Person");
        }

        public virtual void Work(int a)
        {
            Console.WriteLine("Metodas su parametru, kuri naudosim klaseje Person");
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Si uzrasa parasys tiek kartu kiek perduosime per parametra (Person)");
            }
        }
    }
}
