using System.Threading.Channels;

namespace Light
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   light assignment    %%%%%%%%%%%%%%%%%%%");
            Console.WriteLine("----- Declarati două obiecte de tip Candelabru, cu 3, respectiv 5 becuri. Folositi ca puteri maxime pentru becuri 60, 75, 100, respectiv 40, 60, 75, 75, 100. -----");
            byte becuriCan1 = 3;
            int[] puteriMaxCan1 = new int[3] { 60, 75, 100 };
            Candelabru can1 = new Candelabru(becuriCan1, puteriMaxCan1);
            byte becuriCan2 = 5;
            int[] puteriMaxCan2 = new int[5] { 40, 60, 75, 75, 100 };
            Candelabru can2 = new Candelabru(becuriCan2, puteriMaxCan2);

            Console.WriteLine("----- Afisati starea fiecărui obiect Candelabru(dacă e aprins sau stins) dupa ce a fost creat initial -----");
            if (can1.Aprins)
            {
                Console.WriteLine("Candelabrul 1 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 1 este stins");
            }

            if (can2.Aprins)
            {
                Console.WriteLine("Candelabrul 2 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 2 este stins");
            }

            Console.WriteLine("----- Afisati puterea maximă a fiecărui obiect Candelabru -----");
            Console.WriteLine($"Candelabrul 1 are puterea maxima {can1.PutereMaxima}");
            Console.WriteLine($"Candelabrul 2 are puterea maxima {can2.PutereMaxima}");

            Console.WriteLine("----- Aprindeti obiectele Candelabru -----");
            can1.Aprinde();
            can2.Aprinde();

            Console.WriteLine("----- Afisati starea fiecărui obiect Candelabru ( dacă e aprins sau stins) -----");
            if (can1.Aprins)
            {
                Console.WriteLine("Candelabrul 1 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 1 este stins");
            }

            if (can2.Aprins)
            {
                Console.WriteLine("Candelabrul 2 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 2 este stins");
            }

            Console.WriteLine("----- Afisati puterea curentă a fiecărui obiect Candelabru -----");
            Console.WriteLine($"Candelabrul 1 are puterea curenta {can1.PutereCurenta}");
            Console.WriteLine($"Candelabrul 2 are puterea curenta {can2.PutereCurenta}");

            Console.WriteLine("----- Stingeti obiectele Candelabru -----");
            can1.Stinge();
            can2.Stinge();

            Console.WriteLine("----- Afisati puterea curentă a fiecărui obiect Candelabru -----");
            Console.WriteLine($"Candelabrul 1 are puterea curenta {can1.PutereCurenta}");
            Console.WriteLine($"Candelabrul 2 are puterea curenta {can2.PutereCurenta}");

            Console.WriteLine("----- Afisati starea fiecărui obiect Candelabru ( dacă e aprins sau stins) -----");
            if (can1.Aprins)
            {
                Console.WriteLine("Candelabrul 1 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 1 este stins");
            }

            if (can2.Aprins)
            {
                Console.WriteLine("Candelabrul 2 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 2 este stins");
            }

            //Console.WriteLine("----- Printati PUTEREA CURENTA la fiecare bec din candelabre -----");
            //can1.Afiseaza();
            //can2.Afiseaza();

            Console.WriteLine("----- Mariti lumina la fiecare obiect Candelabru cu 80 -----");
            can1.MaresteLumina(80);
            can2.MaresteLumina(80);

            //Console.WriteLine("----- Printati PUTEREA CURENTA la fiecare bec din candelabre -----");
            //can1.Afiseaza();
            //can2.Afiseaza();

            Console.WriteLine("----- Afisati starea fiecărui obiect Candelabru ( dacă e aprins sau stins) -----");
            if (can1.Aprins)
            {
                Console.WriteLine("Candelabrul 1 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 1 este stins");
            }

            if (can2.Aprins)
            {
                Console.WriteLine("Candelabrul 2 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 2 este stins");
            }

            Console.WriteLine("----- Afisati puterea curentă a fiecărui obiect Candelabru -----");
            Console.WriteLine($"Candelabrul 1 are puterea curenta {can1.PutereCurenta}");
            Console.WriteLine($"Candelabrul 2 are puterea curenta {can2.PutereCurenta}");

            Console.WriteLine("----- Reduceti lumina la fiecare obiect Candelabru cu 50 -----");
            can1.ReduceLumina(50);
            can2.ReduceLumina(50);

            //Console.WriteLine("----- Printati PUTEREA CURENTA la fiecare bec din candelabre -----");
            //can1.Afiseaza();
            //can2.Afiseaza();

            Console.WriteLine("----- Afisati starea fiecărui obiect Candelabru(dacă e aprins sau stins) -----");
            if (can1.Aprins)
            {
                Console.WriteLine("Candelabrul 1 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 1 este stins");
            }

            if (can2.Aprins)
            {
                Console.WriteLine("Candelabrul 2 este aprins");
            }
            else
            {
                Console.WriteLine("Candelabrul 2 este stins");
            }

            Console.WriteLine("----- Afisati puterea curentă a fiecărui obiect Candelabru -----");
            Console.WriteLine($"Candelabrul 1 are puterea curenta {can1.PutereCurenta}");
            Console.WriteLine($"Candelabrul 2 are puterea curenta {can2.PutereCurenta}");

            Console.WriteLine("%%%%%%%%%%%%%%%%%%%   End of light assignment    %%%%%%%%%%%%%%%%%%%");
        }
    }
}
