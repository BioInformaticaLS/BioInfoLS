using System;
using System.IO;
using System.Text;

namespace ClassBioInfo
{
    public class BioInformatica
    {
        //FILE

        public const string filesensibile = "sensibile.txt";
        public const string fileresistente = "resistente.txt";

        //LETTURA PRIMO FILE

        public static string LetturaStringa1()
        {

            string stringa1 = "";

            if (File.Exists(filesensibile))
            {
                using (StreamReader sr = new StreamReader(filesensibile, Encoding.UTF8))
                {
                    stringa1 = sr.ReadToEnd();
                }
            }
            return stringa1;
        }

        //LETTURA SECONDO FILE

        public static string LetturaStringa2()
        {

            string stringa2 = "";
             
            if (File.Exists(fileresistente))
            {
                using (StreamReader sr = new StreamReader(fileresistente, Encoding.UTF8))
                {
                    stringa2 = sr.ReadToEnd();
                }
            }
            return stringa2;
        }

        //LUNGHEZZA PRIMO FILE

        public static long LunghezzaStringa1()
        {
            string sensibile = LetturaStringa1();
            long lunghezzasensibile = sensibile.Length;
            return lunghezzasensibile;
        }

        //LUNGHEZZA SECONDO FILE

        public static long LunghezzaStringa2()
        {
            string resistente = LetturaStringa2();
            long lunghezzaresistente = resistente.Length;
            return lunghezzaresistente;
        }

        //POSIZIONE DELLA PRIMA DIFFERENZA

        public static long Prima_differenza()
        {
            string sensibile = BioInformatica.LetturaStringa1();
            string resistente = BioInformatica.LetturaStringa2();

            for (int i = 0; i < Math.Min(sensibile.Length, resistente.Length); i++)
            {
                if (sensibile[i] != resistente[i])
                    return i;
            }

            return -1;
        }

        //PRIMA PORZIONE DI SEGUENZA IDENTICA

        public static string Parte_Uguale()
        {
            string sensibile = BioInformatica.LetturaStringa1();
            string resistente = BioInformatica.LetturaStringa2();
            string parte_uguale = null;

            int index = 0;
            bool same = true;

            do
            {
                if (sensibile[index] == resistente[index])
                {
                    parte_uguale += sensibile[index];
                    index++;
                }
                else
                {
                    same = false;
                }

            } while (same && index < sensibile.Length && index < resistente.Length);

            return parte_uguale;
        }

        //NUMERO CARATTERI DIFFERENTI

        public static int numero_caratteri_differenti()
        {
            int index = 0;
            string sensibile = BioInformatica.LetturaStringa1();
            string resistente = BioInformatica.LetturaStringa2();
            int uguali = 0;
            int differenti = 0;

            do
            {
                if (sensibile[index] == resistente[index])
                {
                    uguali++;
                    index++;
                }
                else
                {
                    differenti++;
                    index++;
                }

            } while (index < sensibile.Length && index < resistente.Length);

            return differenti;
        }
    }
}
