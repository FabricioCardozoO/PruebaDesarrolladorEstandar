using System;
using System.Collections.Generic;

class Nodo
{
    public int Peso { get; }
    public List<Arbol> Subarboles { get; }

    public Nodo(int peso)
    {
        Peso = peso;
        Subarboles = new List<Arbol>();
    }
}

class Arbol
{
    public Nodo Raiz { get; }

    public Arbol(int peso)
    {
        Raiz = new Nodo(peso);
    }

    public void AgregarSubarbol(Arbol subarbol)
    {
        Raiz.Subarboles.Add(subarbol);
    }

    public int CalcularPesoTotal()
    {
        return CalcularPesoRecursivo(Raiz);
    }

    private int CalcularPesoRecursivo(Nodo nodo)
    {
        int pesoTotal = nodo.Peso;
        foreach (var subarbol in nodo.Subarboles)
        {
            pesoTotal += CalcularPesoRecursivo(subarbol.Raiz);
        }
        return pesoTotal;
    }
}

class Program
{
    static void Main()
    {
        // Crear el árbol de ejemplo
        Arbol arbol = new Arbol(5);
        Arbol subarbol1 = new Arbol(10);
        Arbol subarbol2 = new Arbol(8);
        Arbol subarbol3 = new Arbol(15);

        arbol.AgregarSubarbol(subarbol1);
        arbol.AgregarSubarbol(subarbol2);
        arbol.AgregarSubarbol(subarbol3);

        int pesoTotalArbol = arbol.CalcularPesoTotal();
        Console.WriteLine("El peso total del árbol es: " + pesoTotalArbol);
    }
}
