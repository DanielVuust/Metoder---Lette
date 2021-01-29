using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
        private int listMax(List<int> list)
        {
            bool førsteIndex = true;
            int maxNummer = 0;
            foreach (int nummer in list)
            {
                if (førsteIndex)
                {
                    maxNummer = nummer;
                    førsteIndex = false;
                }
                else if (nummer > maxNummer)
                {
                    maxNummer = nummer;
                }

            }
            return maxNummer; 
        } 
        private bool indeholder(List<int> x)
        {
            if (x.Contains('x'))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int gennemsnit(List<int> x)
        {
            int total = 0;
            foreach (int num in x)
            {
                total += num;
            }
            int gennemsnit = total / x.Count;

            return gennemsnit;
        }
        private bool sort(List<int> oldList)
        {
            bool erSoteret = true;
            List<int> newList = new List<int>(oldList);
            newList.Sort();
            for(int i =0; i < oldList.Count; i++)
            {
                if (newList[i] != oldList[i])
                {
                    erSoteret = false;
                }
            }
            return erSoteret;
        }
    }
}
