using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAutoLista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string auto = "";
            List<string> Autot = new List<string>();
            Console.Write("Anna autojen merkit tai x lopettaaksesi: ");
            while (auto.ToUpper() != "X") 
            {
                Console.Write("Auton merkki: ");
                auto = Console.ReadLine();
                if (auto.ToUpper() != "X") 
                { 
                    Autot.Add(auto);
                }
            }

            Autot.Sort();

            Console.WriteLine("Tallensit nämä autot: (yhteensä {0} kappaletta):", Autot.Count);
            
            for (int j = 0; j < Autot.Count; j++) 
            {
                Console.WriteLine(Autot[j]);
            }
            
            string ekaAuto = Autot.First();
            Console.WriteLine("Listan ensimmäinen auto => " +  ekaAuto);
            string vikaAuto = Autot.Last();
            Console.WriteLine("Listan viimeinen auto => " +  vikaAuto);
            Console.ReadLine();
        }
    }
}
