using System;
using System.Collections.Generic;
using System.IO;

class MinhaBiblioteca
{
    static void PopularAleatorio(List<int> lista, int quantidade)
    {
        // instancia o gerador de numeros aleatorios e ao msm tempo define uma semente no tempo atual
        // diferente de C++ que precisa definir a semente separado exemplo: '(srand(time(0)))'
        Random random = new Random();

        for (int i = 0; i < quantidade; i++)
        {
            // equivalente ao push_back() do C++ e ao .append() do python
            lista.Add(random.Next(0, 101));
        }
    }
}