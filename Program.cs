using System;

namespace Programaciondesde1_EJ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe cinco numeros:");
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int mayor = 0;
            int menor = numeros[0];
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > mayor)
                {
                    mayor = numeros[i];
                }
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                }
            }

            Console.WriteLine("El numero mas grande es: {0}", mayor);
            Console.WriteLine("El numero mas pequenio es: {0}", menor);
        }
    }
}
