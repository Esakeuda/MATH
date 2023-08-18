using System;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double sade = 5.0;

            // Lasketaan ympyrän pinta-ala ja ympärysmitta
            double pintaAla = Math.PI * Math.Pow(sade, 2);
            double ymparysmitta = 2 * Math.PI * sade;

            Console.WriteLine("Ympyrän pinta-ala: " + pintaAla);
            Console.WriteLine("Ympärysmitta: " + ymparysmitta);

            Console.ReadLine();
        }
    }
}

