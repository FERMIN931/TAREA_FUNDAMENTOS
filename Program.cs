using System;

class ContadorNumerosPositivos
{
    static void Main()
    {
        int contador = 0;  // Inicializamos el contador de números positivos
        int numero;

        // Empezamos el ciclo while
        while (true)
        {
            Console.Write("Ingresa un número: ");
            numero = int.Parse(Console.ReadLine());

            // Verificamos si el número es negativo
            if (numero < 0)
            {
                break;  // Si el número es negativo, salimos del ciclo
            }
            else
            {
                contador++;  // Si el número es positivo, incrementamos el contador
            }
        }

        // Mostramos la cantidad de números positivos ingresados
        Console.WriteLine("Cantidad de números positivos ingresados: " + contador);
    }
}