using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Løkker
    {
        public void løkke1()
        {
            for (int i = 1; i <=10;  i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

        }
        public void løkke2()
        {
            for (int i = 10; i >0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void løkke3()
        {
            string strNr;
            int nr;
            bool loop = true;
            int i=0;
            do
            {
                Console.WriteLine("Intast et tal");
                strNr = Console.ReadLine();
            } while (!int.TryParse(strNr, out nr));
            while (loop)
            {

                if (i < 32)
                {
                    i++;
                    nr++;
                    Console.Write(nr + " ");
                }
                else if (i < 48)
                {
                    i++;
                    nr--;
                    Console.Write(nr + " ");
                }
                else
                {
                    Console.WriteLine();
                    loop = false;
                }
            }
        }
        
    }
}
