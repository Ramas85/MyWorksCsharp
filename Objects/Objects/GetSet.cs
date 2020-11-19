using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectsInheritanceClassConstructor
{
    public class GetSet
    {
        private string name;
        private int age;
        private string type;
        private char spalva;
        private bool isPilnas;
        // using accessors to get and  
        // set the value of Name and age 
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        //another way to write without set
        public string getType()
        {
            return type;
        }
        public char getSpalva()
        {
            return spalva;
        }

        //auto property
        // public string Name { get; set; }
        // public int Age { get; set; }

        //constructor
        public GetSet(string n, int a, string t, char s)
        {
            name = n;
            age = a;
            type = t;
            spalva = 'b';
        }
        public void SetSpalva(char spalva)
        {
            this.spalva = spalva;
        }

        public bool IsPilnas()
        {
            return isPilnas;
        }
    }
}

