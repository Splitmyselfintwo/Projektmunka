using System;
using System.Collections.Generic;
using System.IO;

namespace VallasProjekt
{
    // Az objektum osztálya
    class VallasKonfliktus
    {
        public int Id { get; set; }
        public string EsemenyNeve { get; set; }
        public string VallasNeve { get; set; }
        public long AldozatokSzama { get; set; }

        // Konstruktor: ez darabolja fel a txt egy sorát
        public VallasKonfliktus(string sor)
        {
            string[] adatok = sor.Split(';');
            Id = int.Parse(adatok[0]);
            EsemenyNeve = adatok[1];
            VallasNeve = adatok[2];
            AldozatokSzama = long.Parse(adatok[3]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<VallasKonfliktus> konfliktusok = new List<VallasKonfliktus>();
            string fajlNev = "adatok.txt";

            try
            {
                // 1. Fájl beolvasása (Algoritmus része)
                string[] sorok = File.ReadAllLines(fajlNev);
                
                // 2. Objektumok példányosítása és listához adása
                foreach (string sor in sorok)
                {
                    konfliktusok.Add(new VallasKonfliktus(sor));
                }

                // 3. Adatok kiírása és összegzés
                long osszesAldozat = 0;
                Console.WriteLine("--- VALLÁSI KONFLIKTUSOK ÉS ÁLDOZATOK --- \n");

                foreach (var k in konfliktusok)
                {
                    Console.WriteLine($"{k.Id}. {k.EsemenyNeve} ({k.VallasNeve})");
                    Console.WriteLine($"   Becsült áldozatok: {k.AldozatokSzama:N0} fő\n");
                    osszesAldozat += k.AldozatokSzama;
                }

                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Összes áldozat a vizsgált listában: {osszesAldozat:N0} fő");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt: {ex.Message}");
                Console.WriteLine("Ellenőrizd, hogy az adatok.txt a megfelelő mappában van-e!");
            }

            Console.ReadLine(); // Vár a kilépés előtt
        }
    }
}
