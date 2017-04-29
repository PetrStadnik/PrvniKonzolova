using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aplikace_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "menu";
            while (i == "menu" )
            {
               
                int programek = 0;
                char programv = '0';
   
            while (programv != '1' && programv != '2' && programv != '3')
            {
                Console.WriteLine("\n \n zvolte si program");
                Console.WriteLine("1 - sčítač");
                Console.WriteLine("2 - obvod a obsah kruhu");
                Console.WriteLine("3 - řada čísel");
                programv = Console.ReadKey().KeyChar;
            }

       
   
               programek = int.Parse(programv.ToString());
          




           
            if (programek == 1)
            {
                    string k;
                    i = "yes";
                    while (i == "yes")
                    {
                    Console.WriteLine("");
                    Console.WriteLine("Vítejte v kalkulačce");

                    Console.WriteLine("Zadejte první číslo:");
                    float a;

                    while (!float.TryParse(Console.ReadLine(), out a))
                    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");

                    Console.WriteLine("Zadejte druhé číslo:");
                    float b;
                   while (float.TryParse(Console.ReadLine(), out b) == false)
                        Console.WriteLine("Nečíslo, zadejte prosím znovu:");

                    


                    float c = a + b;
                    Console.WriteLine("Výsledek");
                    Console.WriteLine(c);

                    Console.WriteLine("pro vypnutí zadejte no, pro opakování yes, pro návrat do menu -menu");
                    k = Console.ReadLine();
                    while (k != "yes" && k != "no" && k != "menu")
                    {
                        Console.WriteLine("neplatná volba, zadejte znovu");
                        k = Console.ReadLine();
                    }
                    i = k;
                }

            }

            if (programek == 2)
            {
                Console.WriteLine("");
                Console.WriteLine("vypočet kruhu");
                Console.WriteLine("Pí: {0}", Math.PI);
                string k;
                i = "yes";
                while (i == "yes")
                {
                    Console.WriteLine("zadejte poloměr kruhu");
                    float r;
                    double o;
                    double s;
                    while (float.TryParse(Console.ReadLine(), out r) == false)
                        Console.WriteLine("Nečíslo, zadejte prosím znovu:");
                    o = 2 * Math.PI * r;
                    s =  Math.PI * r * r;
                    Console.WriteLine("obsah: {0} \n obvod {1} ", s, o);
                  
                    Console.WriteLine("pro vypnutí zadejte no, pro opakování yes, pro návrat do menu -menu");
                    k = Console.ReadLine();
                   while (k != "yes" && k != "no" && k != "menu")
                    {
                        Console.WriteLine("neplatná volba, zadejte znovu");
                        k = Console.ReadLine();
                    }                  
                     i = k;
                }

            }

                if (programek == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("sčítání řady čísel");
                    Console.WriteLine("výsledek získáte zadáním číslice 0");

                    string k;
                    i = "yes";
                    while (i == "yes")
                    {
                        int p = 1;
                        double a = 1;
                        double x = 0;
                        while (a != 0 )
                        {
                           
                            Console.WriteLine("zadejte číslo {0}", p);
                            p++;
                            while (double.TryParse(Console.ReadLine(), out a) == false)
                                Console.WriteLine("Nečíslo, zadejte prosím znovu:");
                            x = x + a;
                        }
                        Console.WriteLine("výsledek {0} ", x);


                        Console.WriteLine("pro vypnutí zadejte no, pro opakování yes, pro návrat do menu -menu");
                        k = Console.ReadLine();
                        while (k != "yes" && k != "no" && k != "menu")
                        {
                            Console.WriteLine("neplatná volba, zadejte znovu");
                            k = Console.ReadLine();
                        }
                        i = k;
                    }

                }



            }








































        }
    }
}
