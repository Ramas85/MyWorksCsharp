using System;
using static Interface.Namas;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            Namas n = new Namas();
            Palapine p = new Palapine();
            n.ijunk();
            p.ijunk();
            IElektra e = n;
            e.ijunk();
            e = p;
            e.ijunk();
            // e = new IElektra(); //tiesioginio interfeiso atstovo negalime sukurti.
            e = new Virdulys();
            e.ijunk();
            e = n;
            Console.WriteLine(e.GetType() == n.GetType());
            Console.WriteLine(e.GetType() == p.GetType());
            Console.WriteLine("************");         
            bool result = e.GetType().IsAssignableFrom(p.GetType());
            Console.WriteLine(result);

            IElektraVanduo ev = n;
            //ev = new SodoNamas();
            
        }
    }
}
