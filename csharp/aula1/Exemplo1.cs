using System;
using System.Collections.Generic;

class Exemplo1
{
    static void Main()
    {
        Random random = new Random();
        List<int> listUniqueNumbers = new List<int>();
        int num;

        System.Console.WriteLine("Quantos numeros inteiros quer gerar?");
        while (true) {
            if (int.TryParse(Console.ReadLine(), out num)) {
            break;
            }
            Console.WriteLine("Valor invalido! Digite apenas numeros.");  
        }
        System.Console.WriteLine($"Numeros para gerar: {num}");


        for (int i = 0; i < num; i++)
        {
            int numeroSorteado = random.Next(0, num);
            if (!listUniqueNumbers.Contains(numeroSorteado)) {
                listUniqueNumbers.Add(numeroSorteado);
            }
        }

        listUniqueNumbers.Sort();

        foreach (int n in listUniqueNumbers)
        {
            System.Console.Write(n + " ");
        }
    }
}