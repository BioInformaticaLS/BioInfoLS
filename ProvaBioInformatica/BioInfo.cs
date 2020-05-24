using System;
using ClassBioInfo;

namespace ProvaBioInformatica
{
    class BioInfo
    {
        static void Main(string[] args)
        {
            //LETTURA STRINGHE
            string sensibile = BioInformatica.LetturaStringa1();
            string resistente = BioInformatica.LetturaStringa2();
            Console.WriteLine($"La prima stringa é: {sensibile}");
            Console.WriteLine("");
            Console.WriteLine($"La seconda stringa é: {resistente}");
            Console.WriteLine("");

            //LUNGHEZZA STRINGHE
            long lunghezzasensibile = BioInformatica.LunghezzaStringa1();
            long lunghezzaresistente = BioInformatica.LunghezzaStringa2(); 
            Console.WriteLine($"La lunghezza della stringa sendibile é: {lunghezzasensibile}");
            Console.WriteLine("");
            Console.WriteLine($"La lunghezza della stringa resistente é: {lunghezzaresistente}");
            Console.WriteLine("");

            //PRIMA DIFERENZA
            long pos_differenza = BioInformatica.Prima_differenza();
            Console.WriteLine($"La prima differenza si trova nella posizione: {pos_differenza}");
            Console.WriteLine("");

            //PRIMA PORZIONE DI STRINGA UGUALE
            string parte_uguale = BioInformatica.Parte_Uguale();
            Console.WriteLine($"La prima parte uguale è: {parte_uguale}");
            Console.WriteLine("");

            //NUMERO CARATTERI DIFFERENTI
            int caratteri_differenti = BioInformatica.numero_caratteri_differenti();
            Console.WriteLine($"Il numero dei caratteri differenti è: {caratteri_differenti}");
            Console.WriteLine("");

            Console.WriteLine("BioInformatica Luca Lombardo & Lucrezia Sabba");

            Console.ReadLine();
        }
    }
}
