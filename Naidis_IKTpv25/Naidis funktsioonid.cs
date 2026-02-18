using System;
using System.Collections.Generic;
using System.Text;

namespace Naidis_IKTpv25
{
    public class naidis_funktsioonid
    {
        /*    public static float Summa(float arv1, float arv2)
            {
                return arv1 + arv2;
            }
            public static string Kuu_nimetus(int kuu_nr)
            {
                string kuu = "";
                switch (kuu_nr)
                {
                    case 1: kuu = "Jaanuar"; break;
                    case 2: kuu = "Veebruar"; break;
                    case 3: kuu = "Märts"; break;
                    case 4: kuu = "Aprill"; break;
                    case 5: kuu = "Mai"; break;
                    case 6: kuu = "Juuni"; break;
                    case 7: kuu = "Juuli"; break;
                    case 8: kuu = "August"; break;
                    case 9: kuu = "September"; break;
                    case 10: kuu = "Oktoober"; break;
                    case 11: kuu = "Novemberr"; break;
                    case 12: kuu = "Detsember"; break;

                    default:
                        kuu = "???";
                        break;
                }
                return kuu;
            }
        */
        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //&& - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
            return hoo;

        }

        
        public static void Muuda_element_massiivis(int[] arvud)
        {
            Console.WriteLine("Kuhu: ");
            int positsioon = int.Parse(Console.ReadLine());
            Console.WriteLine("Milliseks: ");
            int uus_arv = int.Parse(Console.ReadLine());
            arvud[positsioon - 1] = uus_arv;
            Console.WriteLine("Uuendatud massiiv: ");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            }
        }
        public static int[] Täida_massiiv(int[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.Write($"Sisesta {i + 1}. arv: ");
                try
                {
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            return arvud;
        }
        public static void Massiivide_kuvamine(int[] arvud)
        {
            Console.WriteLine("Foreach abil:");
            foreach (int arv in arvud)
            {
                Console.WriteLine($"Sisestatud arv: {arv}");
            }
            Console.WriteLine("For abil: esimene-> viiname");
            for (int i = 0; i < arvud.Length; i++)
            {
                Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            }
            Console.WriteLine("For abil: viimane-> esimene");
            for (int i = arvud.Length - 1; i > -1; i--)
            {
                Console.WriteLine($"Sisestatud arv: {arvud[i]}");
            }
        }
        //  1. Juhuslike arvude ruudud \\ Случайные числовые квадраты
        public static int[] GenereeriRuudud(int min, int max)
        {
            Random rnd = new Random();
            int n = rnd.Next(min, max + 1);
            int m = rnd.Next(min, max + 1);
            if (n > m) { int t = n; n = m; m = t; }

            int[] arr = new int[m - n + 1];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = (n + i) * (n + i);

            return arr;
        }

        // 2. Viie arvu analüüs \\ Анализ пятизначных чисел
        public static Tuple<double, double, double> AnalüüsiArve(double[] arvud)
        {
            double sum = 0;
            double korr = 1;

            foreach (double a in arvud)
            {
                sum += a;
                korr *= a;
            }

            double avg = sum / arvud.Length;
            return Tuple.Create(sum, avg, korr);
        }

        // 3. Nimed ja vanused \\ Имена и возраст
        public static Tuple<int, double, Isik, Isik> Statistika(List<Isik> inimesed)
        {
            int sum = 0;
            Isik vanim = inimesed[0];
            Isik noorim = inimesed[0];

            foreach (Isik i in inimesed)
            {
                sum += i.Vanus;
                if (i.Vanus > vanim.Vanus) vanim = i;
                if (i.Vanus < noorim.Vanus) noorim = i;
            }

            double avg = sum / (double)inimesed.Count;
            return Tuple.Create(sum, avg, vanim, noorim);
        }

        //  4. Osta elevant \\ Купите слона
        public static List<string> KuniMärksõnani(string marksona, string fraas)
        {
            List<string> vastused = new List<string>();
            string s;
            do
            {
                Console.WriteLine(fraas);
                s = Console.ReadLine();
                vastused.Add(s);
            } while (s != marksona);

            return vastused;
        }

        //  5. Arvamise mäng \\ Игра в угадывание
        public static void ArvaArv()
        {
            Random rnd = new Random();
            int saladus = rnd.Next(1, 101);

            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Paku arv: ");
                int p = int.Parse(Console.ReadLine());

                if (p == saladus)
                {
                    Console.WriteLine("Õige!");
                    return;
                }
                else if (p < saladus)
                    Console.WriteLine("Liiga väike");
                else
                    Console.WriteLine("Liiga suur");
            }

            Console.WriteLine("Mäng läbi! Õige arv oli " + saladus);
        }

        // 6. Suurim neliarv \\ Наибольшее четырехзначное число
        public static int SuurimNeliarv(int[] arvud)
        {
            Array.Sort(arvud);
            Array.Reverse(arvud);

            return arvud[0] * 1000 + arvud[1] * 100 + arvud[2] * 10 + arvud[3];
        }

        //  7. Korrutustabel \\ Таблица умножения
        public static int[,] GenereeriKorrutustabel(int r, int v)
        {
            int[,] table = new int[r, v];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < v; j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                    Console.Write(table[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

            return table;
        }

        // 8. Õpilastega mängimine \\ Игра со студентами
        public static void Opilased()
        {
            string[] nimed = { "Aadu", "Berit", "Caro", "Davis", "Ene", "Fred", "Gina", "Hendrik", "Ivo", "Jaan" };

            nimed[2] = "Kati";
            nimed[5] = "Mati";

            int nr = 0;
            while (nr < nimed.Length)
            {
                if (nimed[nr].StartsWith("A"))
                    Console.WriteLine($"Tere, {nimed[nr]}!");
                nr++;
            }

            for (int i = 0; i < nimed.Length; i++)
                Console.WriteLine($"{i}: {nimed[i]}");

            foreach (var nimi in nimed)
                Console.WriteLine(nimi.ToLower());

            nr = 0;
            do
            {
                Console.WriteLine($"Tere, {nimed[nr]}!");
                nr++;
            } while (nr < nimed.Length && nimed[nr - 1] != "Mati");
        }

        //  9. Arvude ruudud \\ Квадраты чисел
        public static void Arvude_ruudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            for (int i = 0; i < arvud.Length; i++)
                Console.WriteLine($"{arvud[i]}² = {arvud[i] * arvud[i]}");

            foreach (var a in arvud)
                Console.WriteLine($"{a} * 2 = {a * 2}");

            int count = 0, idx = 0;
            while (idx < arvud.Length)
            {
                if (arvud[idx] % 3 == 0)
                    count++;
                idx++;
            }
            Console.WriteLine($"Arve, mis jaguvad 3-ga: {count}");
        }

        // 10. Positiivsed ja negatiivsed \\ Положительные и отрицательные
        public static void Positiivsed_negatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            int pos = 0, neg = 0, nul = 0;

            foreach (var a in arvud)
            {
                if (a > 0) pos++;
                else if (a < 0) neg++;
                else nul++;
            }

            Console.WriteLine($"Positiivseid: {pos}, Negatiivseid: {neg}, Nulle: {nul}");
        }

        // 11. Keskmisest suuremad \\ Больше среднего
        public static void Keskmisest_suuremad()
        {
            Random rnd = new Random();
            int[] arvud = new int[15];
            int sum = 0;
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 101);
                sum += arvud[i];
            }
            double avg = sum / (double)arvud.Length;
            Console.WriteLine($"Keskmine: {avg}");

            Console.WriteLine("Keskmisest suuremad arvud:");
            foreach (var a in arvud)
                if (a > avg)
                    Console.Write(a + " ");
            Console.WriteLine();

            int idx = 0;
            Console.WriteLine("Väljasta kuni kohtad arvu < 10:");
            do
            {
                Console.Write(arvud[idx] + " ");
                idx++;
            } while (idx < arvud.Length && arvud[idx - 1] >= 10);
            Console.WriteLine();
        }

        // 12. Kõige suurema arvu otsing \\ Нахождение наибольшего числа
        public static void Suurim_arv()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            int suurim = numbrid[0];
            int indeks = 0;

            for (int i = 1; i < numbrid.Length; i++)
            {
                if (numbrid[i] > suurim)
                {
                    suurim = numbrid[i];
                    indeks = i;
                }
            }

            Console.WriteLine($"Suurim arv: {suurim}, indeks: {indeks}");
        }

        // 13. Paari- ja paaritud loendused \\ Четные и нечетные числа
        public static void Paari_paaritud()
        {
            Random rnd = new Random();
            List<int> arvud = new List<int>();
            for (int i = 0; i < 20; i++)
                arvud.Add(rnd.Next(1, 101));

            int sum = 0;
            for (int i = 0; i < arvud.Count; i++)
                if (arvud[i] % 2 == 0)
                    sum += arvud[i];
            Console.WriteLine($"Paarisarvude summa: {sum}");

            int paaritud_sum = 0, paaritud_count = 0;
            foreach (var a in arvud)
                if (a % 2 != 0)
                {
                    paaritud_sum += a;
                    paaritud_count++;
                }
            Console.WriteLine($"Paaritute arvude keskmine: {(paaritud_count > 0 ? paaritud_sum / (double)paaritud_count : 0)}");

            int count = 0, idx = 0;
            while (idx < arvud.Count)
            {
                if (arvud[idx] > 50) count++;
                idx++;
            }
            Console.WriteLine($"Arve suuremad kui 50: {count}");
        }
    }
}
