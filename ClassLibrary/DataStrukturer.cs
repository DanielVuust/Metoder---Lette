using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassLibrary
{
    public class DataStrukturer
    {
        public void array()
        {
            int[] array = new int[9];
            for (int i = 0; i < 9; i++)
            {
                array[i] = i + 1;
            }
            foreach (int number in array)
            {
                if (number == array[5])
                {
                    array[5] = array[5 - 1] * 2;
                }
            }
        }
        public void liste()
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 20; i++)
            {
                list.Add(i);
            }
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    list.Remove(i);
                }
            }

            list[3] = 17;

            List<int> listB = new List<int>(list);
            listB.Reverse();
            foreach (int number in list) Console.Write(number + " ");
            Console.WriteLine();
            foreach (int number in listB) Console.Write(number + " ");
            Console.WriteLine();
        }
        public void lotto()
        {
            Random ran = new Random();
            int[] vinderKupon = new int[7];
            for (int i = 0; i < 7; i++)
            {
                int ranNumber;
                do
                {
                    ranNumber = ran.Next(1, 21);
                } while (vinderKupon.Contains(ranNumber));
                vinderKupon[i] = ranNumber;
            }

            int[] brugerKupon = new int[7];
            for (int i = 0; i < 7; i++)
            {
                string strNr;
                int intNr;
                do
                {
                    Console.WriteLine("Indtast en tal imellem 1 og 20 du vil have tal nr " + (i + 1) + " til at være på din kupon");
                    strNr = Console.ReadLine();

                } while (!int.TryParse(strNr, out intNr) || intNr > 20 || intNr < 1 || brugerKupon.Contains(intNr));
                brugerKupon[i] = intNr;

            }
            Console.Write("Dette er din kupon: ");
            foreach (int brugerNummer in brugerKupon)
            {
                Console.Write(brugerNummer + " ");
            }

            int antalRigtige = 0;
            for (int i = 0; i < 7; i++)
            {
                if (vinderKupon[i] == brugerKupon[i])
                {
                    antalRigtige++;
                }
            }
            Console.WriteLine("\n\n" + "Du fik " + antalRigtige + " rigtige tal");
            string præmie;
            if (antalRigtige == 7)
            {
                præmie = "1000000.00 dkk";
            }
            else
            {
                præmie = "0.00 dkk";
            }
            Console.WriteLine("Din præmie er " + præmie);
            Console.Write("Vinder kuponen var: ");
            foreach (int vinderNummer in vinderKupon)
            {
                Console.Write(vinderNummer + " ");
            }
            Console.WriteLine();
            

        }
        public void gætTallet()
        {
            Random ran = new Random();
            int ranNumber = ran.Next(1, 101);
            bool hemmeligTalGættet = false;
            int antalGæt = 0;
            while (!hemmeligTalGættet)
            {
                antalGæt++;
                string strGæt;
                int gæt;
                do
                {
                    Console.WriteLine("Gæt tallet som er imellem 1 og 100");
                    strGæt = Console.ReadLine();
                } while (!int.TryParse(strGæt, out gæt));
                if (gæt == ranNumber)
                {
                    hemmeligTalGættet = true;
                    Console.WriteLine("Tillykke du gættede tallet med {0} antal forsøg", antalGæt);
                }
                else if (gæt < ranNumber)
                {
                    Console.WriteLine("Du gættede for lavt prøv igen");
                }
                else if (gæt> ranNumber)
                {
                    Console.WriteLine("Du gættede for højt prøv igen");
                }
            }
        }
    }
}
