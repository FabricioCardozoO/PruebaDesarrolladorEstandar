using System;

class Program
{
    static string ConvertirABaseK(int x, int k)
    {
        if (x == 0)
        {
            return "0"; // Si x es cero, la representación en cualquier base es simplemente "0"
        }

        string resultado = string.Empty;

        while (x > 0)
        {
            int residuo = x % k;
            resultado = residuo.ToString() + resultado; // Agregar el residuo al principio del resultado
            x = x / k; // Siguiente cociente
        }

        return resultado;
    }

    static void Main()
    {
        Console.WriteLine("Ingrese el número en base 10:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la base k:");
        int k = Convert.ToInt32(Console.ReadLine());

        string representacionBaseK = ConvertirABaseK(x, k);
        Console.WriteLine($"El número {x} en base {k} es: {representacionBaseK}");
    }
}
