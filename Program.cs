using System;

class CalculadoraPromedio
{
    static void Main()
    {
        double suma = 0;  // Variable que acumula la suma de los números
        int contador = 0; // Variable que cuenta la cantidad de números ingresados
        string respuesta;

        do
        {
            Console.Write("Ingresa un número: ");
            double numero = double.Parse(Console.ReadLine());
            // Sumamos el número ingresado
            suma += numero;
            // Incrementamos el contador de números
            contador++;  

            // Preguntamos si desea ingresar otro número
            Console.Write("¿Deseas ingresar otro número? (s/n): ");
            respuesta = Console.ReadLine().ToLower();
            // Repetimos si la respuesta es "s"
        } while (respuesta == "s");  

        if (contador > 0)
        {
            // Calculamos el promedio
            double promedio = suma / contador;  
            Console.WriteLine("El promedio es: " + promedio);
        }
        else
        {
            Console.WriteLine("No se ingresaron números.");
        }
    }
}