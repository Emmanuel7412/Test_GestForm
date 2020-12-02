using System;
using System.Collections.Generic;

namespace Test_GestForm
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var listRand = new List<int>();

            for (int i = 0; i < 50; i++)
            {
                listRand.Add(rand.Next(-1000, 1000));
            }

            foreach (int elt in listRand)
            {
                Console.WriteLine("Nombre : " + elt + " - Résultat : " + checkModulo(elt));
            };

        }
        static string checkModulo(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
                return "GestForm";
            if (number % 3 == 0)
                return "Geste";
            if (number % 5 == 0)
                return "Forme";
            return number.ToString();
        }
    }
}
