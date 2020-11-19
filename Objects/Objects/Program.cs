using ObjectsInheritanceClassConstructor;
using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)     
        {
            /*
                        Puodukas p1 = new Puodukas('p', 150);
                        p1.medziaga = 'B';
                        p1.turis = 150;

                        Puodukas p2 = new Puodukas('s', 350);
                        p2.medziaga = 'S';
                        p2.turis = 350;
                        p2.kiekis = 200;
                        p2.ipilk(200);

                        Puodukas p3 = new Puodukas('p', 150);
                               p3.medziaga = 'p';
                               p3.turis = 150;
                               p1.kiekis = 100;
                                p3 = p1;
                                p3.kiekis -= 20;
                        p1.ipilk(100);
                        p2.ipilk(200);
                        p2.ipilk(200);
                        p2.isgerk(400);

                        Console.WriteLine(p1); 
                        Console.WriteLine(p2.kiekis);
                        Console.WriteLine(p3);
            */

            //***********************************************Spausdinam naujai sukurta objekta*****************************************************
            /*
                       Termosas ter1 = new Termosas(500);
                       Console.WriteLine("Buvusi temperatura - " + ter1.temp);
                       Console.WriteLine("medziaga - " + ter1.medziaga);
                       Console.WriteLine("turis - " + ter1.turis);
                       ter1.ipilk(100);
                       Console.WriteLine("kiekis - " + ter1.kiekis);
                       //***********************************************pridedam pora metodu i termosa pasildyk,atsaldyk****************************
                       Console.WriteLine("***************************");
                       ter1.pasildyk(70);
                       Console.WriteLine("Nauja temperatura - " + ter1.temp);
                       //Niuansas 
                       Puodukas pt = ter1;
                       pt.isgerk(20);
                       ter1.atsaldyk(10);
                       pt = new Puodukas('P', 150);
                       //nevygdys zemiau esancio metodo. Kadangi dabar kintamasis pt jau rodo i nauja Objekta tipo: Puodukas.
                       //pt.pasildyk(10);
                       pt = new Termosas(1000);
                       //zemiau esantis metodas neveiks.
                       //pt.pasildyk(10);         
                       Termosas t2 = (Termosas)pt;
                       //dabar veiks,nes padarem klases castinga
                       //pt.pasildyk(10);

                       //zemiau neleis,nes ter1 yra Termosas tipo.
                       //ter1 = new Puodukas('S', 350);
           
            //***************************************************************************************************************************************
            Termosas t5 = new Termosas(500);
            t5.ipilk(10);
            Console.WriteLine(t5.temp);
            */
            //************************************************************get set********************************************************************
            /* 
            GetSet g1 = new GetSet("ram", 15, "tipas", 'j');
            Console.WriteLine(g1.getSpalva());
            g1.SetSpalva('R');
            Console.WriteLine(g1.getSpalva());  
            */
            //*************************************************************String**********************************************************************
            String s = "Labas";
            Console.WriteLine(s);
            s = s + "Pasauli";
            Console.WriteLine(s);
            // lyginam objektus
            Console.WriteLine("lyginam objektus ar rodo i ta pati objekta?");
            Puodukas p1 = new Puodukas('P', 100);
            Puodukas p2 = new Puodukas('P', 100);
            p1 = p2;
            if (p1 == p2)
            {
                Console.WriteLine("tas pats puodukas");

            }else
            {
                Console.WriteLine("kitas");
            }
            Console.WriteLine("*******************************");
            String a = "Hello";
            Console.WriteLine(a);
            a = a + "";
            if(a == "Hello")
            {
                Console.WriteLine("lygu");
            }
            else
            {
                Console.WriteLine("nelygu");
            }
            Console.WriteLine("*******************************");
            String b = "Labas \npasauli , \uA54F";
            Console.WriteLine(b);

            Puodukas p7 = new Puodukas('S',200);
            Console.WriteLine(p7);

            Console.WriteLine(p7.toString());            
        }
    }
}
