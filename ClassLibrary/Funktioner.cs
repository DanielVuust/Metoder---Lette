using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Funktioner
    {
        public void mainFunktion()
        {
            int tal1;
            int tal2;
            string strTal1;
            string strTal2;
            do
            {
                Console.WriteLine("Skriv et tal");
                strTal1 = Console.ReadLine();
            } while (!int.TryParse(strTal1, out tal1));
            do
            {
                Console.WriteLine("Skriv tal nr 2");
                strTal2 = Console.ReadLine();
            } while (!int.TryParse(strTal2, out tal2));
            Console.WriteLine("Tal1 + Tal2  = " + sum(tal1, tal2));
        }
        private int sum(int a, int b)
        {
            return a + b;
        }
        private int division(int a, int b)
        {
            return a / b;
        }
        private decimal gårOpI(int a, int b)
        {
            decimal c = a / b;
            return Math.Floor(c);
        }
        private int listMax(int[] list)
        {
            int maxNummer;
            foreach (int nummer in list)
            {
                if (nummer == list[0] && nummer > nummer)
                {

                }

            }

            return 
        } 
    }
}
