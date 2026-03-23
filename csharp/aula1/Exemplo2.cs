using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

class Exemplo2
{

    static public void PopularListArquivo(List<string> lista, string nomeArquivo)
    {
        File.WriteAllLines(nomeArquivo, lista);
    }

    static void Main()
    {
        Random random = new Random();
        string letras = "abcdefghijklmnopqrstuvwxyz";
        List<string> lista = new List<string>();

        int n;
        System.Console.WriteLine("Quantos nomes quer gerar? ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out n))
            {
                break;
            }
            System.Console.WriteLine("Entrada invalida! Digite um numero inteiro.");
        }

        int tamanhoPalavra;
        System.Console.WriteLine("Qual tamanho da palavra a ser sorteada? ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out tamanhoPalavra))
            {
                break;
            }
            System.Console.WriteLine("Entrada invalida! Digite um numero inteiro.");
        }


        int i = 0;
        while (i < n)
        {
            string palavra = "";
            for (int j = 0; j < tamanhoPalavra; j++)
            {
                int posicaoLetras = random.Next(0, letras.Length);
                palavra += letras[posicaoLetras];
            }
            if (!lista.Contains(palavra))
            {
                lista.Add(palavra);
                i++;
            }
        }
        lista.Sort();

        foreach (string palavra in lista)
        {
            System.Console.Write(palavra + " ");
        }
        PopularListArquivo(lista, "palavras.txt");
    }
}