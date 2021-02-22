using System;
using Operazioni;

namespace OrdinamentoStipendiMaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la dimensione dell'array");
            int k = int.Parse(Console.ReadLine());
            double[] array = new double[k];
            Gestione.Riempimento(array);
            Gestione.BubbleSort1(array);
            Console.WriteLine($"il min è {array[0]}.");
            Console.WriteLine($"il max è {array[array.Length - 1]}.");
            Console.Write("l'array ordinato è: ");
            Gestione.Stampa(array);


        }
    }
}
