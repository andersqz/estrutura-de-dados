using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.IO.Pipes;

class Teste
{
    static void Main()
    {
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};
        
    }
}

class Clima
{
    public string Ano;
    public string Mes;
    public string Temperatura;
    public string precipitacao;

        public Clima(string ano, string mes, string temperatura, string precipitacao)
    {
        Ano = ano;
        Mes = mes;
        Temperatura = temperatura;
        Precipitacao = precipitacao;
    }
    
    public static List<Clima> DadosVerao(List<Clima> lista, string mesesVerao)
    {
        List<Clima> dadosVerao = new List<Clima>();

        foreach (Clima clima in lista)
        {
            foreach (string mes in mesesVerao)
            {
                if (clima.Mes == mes)
                {
                    dadosVerao.Add(clima);
                    break;
                }
            }
        }
        return dadosVerao;
    }

}