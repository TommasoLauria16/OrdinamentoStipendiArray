using System;

namespace Operazioni
{
    public class Gestione
    {
        public static void Riempimento(double[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"inserisci l'elemento in posizione {i+1}");
                array[i] = double.Parse(Console.ReadLine());

            }
        }
        public static void BubbleSort1(double[] array)
        {
            int x, y;
            double temp;
            for (x = 0; x < array.Length - x; x++)
            {
                for (y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temp = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temp;
                    }
                }
            }
        }
        public static void Stampa(double[] array)
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            Console.WriteLine($"{array[array.Length - 1]}.");
        }

    }
}
