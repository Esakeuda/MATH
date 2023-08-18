using System;

namespace TervehdysNimellä
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kysytään käyttäjältä nimi ja tallennetaan se muuttujaan
            Console.WriteLine("Syötä nimesi:");
            string nimi = Console.ReadLine();

            // Hae tämänhetkinen päivämäärä ja aika
            DateTime nykyinenAika = DateTime.Now;

            // Tulostetaan tervehdys käyttäjän nimellä ja nykyisellä päivämäärällä/ajalla
            Console.WriteLine("Hei " + nimi + "! Tervetuloa " + nykyinenAika);

            // Pysäytetään ohjelma odottamaan syötettä ennen sulkemista
            Console.ReadLine();
        }
    }
}
