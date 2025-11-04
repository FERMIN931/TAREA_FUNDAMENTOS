using System;

class Program
{
    static void Main()
    {
        int suma = 0; // Variable para acumular la suma

        // Ciclo For que recorre los números del 1 al 100
        for (int i = 1; i <= 100; i++)
        {
            // Verificamos si el número es par
            if (i % 2 == 0)
            {
                suma += i; // Acumulamos el número par
            }
        }

        // Mostramos la suma total de los números pares
        Console.WriteLine("La suma de los números pares entre 1 y 100 es: " + suma);
    }
}