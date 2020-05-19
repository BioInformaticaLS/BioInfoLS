using System;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            //string stringa = ClassBioInfo.BioInformatica.LetturaStringha2();
            //Console.Write(stringa);
            long lunghezzasensibile = ClassBioInfo.BioInformatica.LunghezzaStringa1();
            Console.WriteLine(lunghezzasensibile);
            long lunghezzaresistente = ClassBioInfo.BioInformatica.LunghezzaStringa2();
            Console.WriteLine(lunghezzaresistente);
            long differenza = ClassBioInfo.BioInformatica.Prima_differenza();
            Console.WriteLine(differenza);
            string parte_uguale = ClassBioInfo.BioInformatica.Parte_Uguale();
            Console.WriteLine(parte_uguale);
            int differenti = ClassBioInfo.BioInformatica.numero_caratteri_differenti();
            Console.WriteLine($"I caratteri differenti sono {differenti}");
            Console.ReadLine();
        }
    }
}
