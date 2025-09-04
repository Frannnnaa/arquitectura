using System;

class PruebaArray
{
    static void Main()
    {
        // Declarar y crear un array de enteros
        int[] numeros = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Elementos del array:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Posición " + i + ": " + numeros[i]);
        }
    }
}
