using System;

class Program
{
    static void Main()
    {
        
    }

    static void exibir(List<int> lista)
    {
        foreach (int item in lista)
        {
            System.Console.WriteLine(item);
        }
    }

    List<int> lista = new List<int>();
    Random gerador = new Random{};
    int valor;
    for (int i = 0; i < 100; i++){
        valor = gerador.Next(400);
        if (!lista.Contains(valor))
    }
}

