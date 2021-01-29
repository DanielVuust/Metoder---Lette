using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace Metoder___Lette
{
    public class Program
    {
        static void Main(string[] args)
        {
            KonsolInputOgOutput konsolinputogoutput = new KonsolInputOgOutput();
            konsolinputogoutput.toHeltal();
            konsolinputogoutput.pythagoras();
            konsolinputogoutput.alderOgNavn();

            Løkker løkker = new Løkker();
            løkker.løkke1();
            løkker.løkke2();
            løkker.løkke3();


            DataStrukturer datastrukturer = new DataStrukturer();

            datastrukturer.array();
            datastrukturer.liste();
            datastrukturer.lotto();
            datastrukturer.gætTallet();

            Funktioner funktioner = new Funktioner();

            funktioner.mainFunktion();

            Console.ReadKey();
        }
    }
}
