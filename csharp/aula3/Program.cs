using System;
using System.Runtime.Versioning;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Linq.Expressions;

class Program
{
    static void Main()
    {
        string nomeArquivo = "dados.csv";

        List<Clima> dadosClimaticos = new List<Clima>();
        List<Clima> dadosVerao = new List<Clima>();
        List<Clima> dadosInverno = new List<Clima>();
        List<Clima> dadosOutono = new List<Clima>();

        dadosClimaticos = Clima.LerDadosEpassarParaLista(nomeArquivo, dadosClimaticos);
        dadosVerao = Clima.DadosVerao(dadosClimaticos);
        dadosInverno = Clima.DadosInverno(dadosClimaticos);
        dadosOutono = Clima.DadosOutono(dadosClimaticos);


    } // Fim Método Main
} // Fim Class Principal
 

 // Classe clima (aqui acontece toda brincadeira)
class Clima
{
    // declaração dos atributos da classe
    public string Ano;
    public string Mes;
    public string Temperatura;
    public string Precipitacao;
 

    // Classe construtor, sem o this
    public Clima(string ano, string mes, string temperatura, string precipitacao)
    {
        Ano = ano;
        Mes = mes;
        Temperatura = temperatura;
        Precipitacao = precipitacao;
    }

    // esse método ToString serve para exibir na tela os atributos da classe quando solicitado
    // por exemplo, ao printar o objeto instanciado 'clima' da classe Clima, 
    // vai mostrar o conteudo dos atributos da classe
    public override string ToString()
    {
        return $"Ano: {Ano} | Mes: {Mes} | Temperatura: {Temperatura} | Precipitacao: {Precipitacao}";
    }
   

    // Método que recebe como parâmetros o nome do arquivo e uma lista vazia da classe Clima
    // ela le o conteudo do arquivo e salva em uma variável 'linha', essa variável linha é repartida com o 'Split(',')' 
    // em cada virgula do arquivo, cada pedaço separado é salvo no vetor 'partes', após, é salvo cada posição desse vetor
    // em uma variavel local correspondente com o dado do arquivo, depois é instanciado um objeto da classe Clima com os parametros
    // ano, mes, temperatura e precipitação, esse objeto pe salvo na lista que foi passada como parâmetro, cada iteração do loop,
    // pega uma linha e segue o fluxo falado acima
    public static List<Clima> LerDadosEpassarParaLista(string nomeArquivo, List<Clima> lista)
    {  
        string[] linhas = File.ReadAllLines(nomeArquivo);
 
        for (int i = 1; i < linhas.Length; i++)
        {
            string linha = linhas[i];
            string[] partes = linha.Split(',');
 
            string ano = (partes[0]);
            string mes = partes[1];
            string temperatura = partes[2];
            string precipitacao = partes[3];
 
            Clima clima = new Clima(ano, mes, temperatura, precipitacao);
            lista.Add(clima);
        }
        return lista;
    }
 

    // método que recebe a lista com todos os dados climáticos e usa um loop foreach
    // para percorrer a lista por completo, e exibir na tela
    public static void ExibirListaGeral(List<Clima> lista)
    {
        foreach (Clima elemento in lista)
        {
            System.Console.WriteLine(elemento.ToString());
        }
    }
 

    // 
    public static List<Clima> DadosVerao(List<Clima> lista)
    {
        List<Clima> dadosVerao = new List<Clima>();
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};

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


    public static List<Clima> DadosInverno(List<Clima> lista)
    {
        List<Clima> dadosInverno = new List<Clima>();
        string[] mesesInverno = {"Agosto", "Setembro", "Outubro", "Novembro"};

        foreach (Clima clima in lista)
        {
            foreach (string mes in mesesInverno)
            {
                if (clima.Mes == mes)
                {
                    dadosInverno.Add(clima);
                    break;
                }
            }
        }
        return dadosInverno;
    }


    public static List<Clima> DadosOutono(List<Clima> lista)
    {
        List<Clima> dadosOutono = new List<Clima>();
        string[] mesesOutono = {"Abril", "Maio", "Junho", "Julho"};

        foreach (Clima clima in lista)
        {
            foreach (string mes in mesesOutono)
            {
                if (clima.Mes == mes)
                {
                    dadosOutono.Add(clima);
                    break;
                }
            }
        }
        return dadosOutono;
    }

}