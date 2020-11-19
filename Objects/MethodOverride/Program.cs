using System;

namespace MethodOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pp = new Student();
            pp.Work();
            pp = new Person();
            pp.Work();
            pp = new Schoolboy();
            pp.Work();
            pp.Work(5);
        }
    }
}
