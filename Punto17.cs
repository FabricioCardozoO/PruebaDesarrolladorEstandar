using System;

class Program
{
    static double DivisionDeEnteros(int dividendo, int divisor)
    {
        // Verificar que el divisor no sea cero
        if (divisor == 0)
        {
            throw new ArgumentException("Error: No se puede dividir por cero.");
        }
        
        // Calcular el resultado de la división
        return (double)dividendo / divisor;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el dividendo:");
        int dividendo = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el divisor:");
        int divisor = Convert.ToInt32(Console.ReadLine());

        try
        {
            double resultado = DivisionDeEnteros(dividendo, divisor);
            Console.WriteLine("El resultado de la división es: " + resultado);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
