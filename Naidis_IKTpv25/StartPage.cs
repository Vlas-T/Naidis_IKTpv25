using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class StartPage
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("3. Osa. Kordused ja Listid, massivid");
            Console.WriteLine("For:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Tere, {i + 1}!");
            }
            Console.WriteLine("While:");
            int j = 0;
            while (j < 10)
            {
                Console.WriteLine($"Tere, {j + 1}!");
                j++;
            }
            Console.WriteLine("Do:");
            do
            {
                Console.WriteLine($"Tere, {11 - j}!");
                j--;
            }
            while (j != 0);
            int[] arvud = new int[5];
            Console.WriteLine("Täisarvude massiiv:");
            arvud = Naidis_funktsioonid.Täida_massiiv(arvud);
            Naidis_funktsioonid.Massiivide_kuvamine(arvud);

            //Küsi mis positsioonil muuda element ja mis väärtuseks, muuda element ja kuva massiiv
            Naidis_funktsioonid.Muuda_element_massiivis(arvud);

            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }
            //  Meetodite näited
            Console.WriteLine("\nJuhuslike arvude ruudud:");
            var ruudud = Naidis_funktsioonid.GenereeriRuudud(1, 10);
            foreach (var r in ruudud) Console.WriteLine(r);

            Console.WriteLine("\nAnalüüsi viie arvu tulemus:");
            double[] arvud2 = { 1, 2, 3, 4, 5 };
            var t = Naidis_funktsioonid.AnalüüsiArve(arvud2);
            Console.WriteLine($"Summa: {t.Item1}, Keskmine: {t.Item2}, Korrutis: {t.Item3}");

            Console.WriteLine("\nKorrutustabel 5x5:");
            Naidis_funktsioonid.GenereeriKorrutustabel(5, 5);

            Console.WriteLine("\nÕpilastega mängimine:");
            Naidis_funktsioonid.Opilased();
            Naidis_funktsioonid.Arvude_ruudud();
            Naidis_funktsioonid.Positiivsed_negatiivsed();
            Naidis_funktsioonid.Keskmisest_suuremad();
            Naidis_funktsioonid.Suurim_arv();
            Naidis_funktsioonid.Paari_paaritud();


            /*Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid, Alamfunktsioonid/meetodid");
            Console.BackgroundColor= ConsoleColor.Green;
            Console.ForegroundColor= ConsoleColor.Blue;
            string tekst= "Tere tulemast C#-i maailma!";
            Console.WriteLine($"Oli loodud muutuja tekst, mis võrdub: {tekst}");
            Console.WriteLine("Oli loodud muutuja tekst, mis võrdub: {0}", tekst);
            Console.Write("Mis on sinu nimi?: ");
            string nimi = Console.ReadLine();
            Console.Write("Kui vana sa oled?: ");
            try
            {
                int vanus = int.Parse(Console.ReadLine());
                Console.WriteLine($"Tere {nimi}. Sa oled {vanus} aastat vana");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);              
            }
            try
            {
                Console.Write("Arv 1: ");
                float a = float.Parse(Console.ReadLine());
                Console.Write("Arv 2: ");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_funktsioonid.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            1.
            Console.WriteLine(Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            2. 
            tekst = Naidis_funktsioonid.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(tekst);
            Juku ja kino
            Console.Write(Osa2_funktsioonid.Juku());//vaikimisi nimi= juku
            Console.Write(Osa2_funktsioonid.Juku(nimi));
            Console.Write(Osa2_funktsioonid.Juku("Python"));
             Pinginaabrid
            Console.WriteLine("\nPinginaabrid:");
            Console.WriteLine(Osa2_funktsioonid.Pinginaabrid());
             Ristkülik + remont
            Console.WriteLine("\nRistkülik ja remont:");
            Osa2_funktsioonid.RistkylikJaRemont();
             30% soodustusega alghind
            Console.WriteLine("\nAlghinna arvutamine 30% soodustuse järgi:");
            Osa2_funktsioonid.Alghind();
             Temperatuur
            Console.WriteLine("\nTemperatuuri kontroll:");
            Osa2_funktsioonid.Temperatuur();
             Pikkus
            Console.WriteLine("\nPikkuse kontroll:");
            Osa2_funktsioonid.Pikkus();
             Pikkus + sugu
            Console.WriteLine("\nPikkus ja sugu:");
            Osa2_funktsioonid.PikkusJaSugu();
             Pood
            Console.WriteLine("\nPoe ostude arvutamine:");
            Osa2_funktsioonid.Pood();

           Console.WriteLine("\nKõik ülesanded on lõpule viidud!");
             */
        }
    }
}
