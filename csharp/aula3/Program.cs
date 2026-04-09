
    // usar as listas que separa por frio, quente, e ameno e calcular quantas frio, quente e ameno tem em cada estação, VERAO JA FOI FEITO
    // calcular agora para inverno e outono


using System;
using System.Runtime.Versioning;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Net;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

class Program
{
    static void Main()
    {
        string nomeArquivo = "dados.csv";
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};
        string[] mesesInverno = {"Agosto", "Setembro", "Outubro", "Novembro"};
        string[] mesesOutono = {"Abril", "Maio", "Junho", "Julho"};
        
        // listas que vao receber os dadosClimaticos separando para cada lista uma estação, lista com dados verao, lista com dados inverno e lista com dados outono
        List<Clima> dadosClimaticos = new List<Clima>();
        List<Clima> dadosVerao = new List<Clima>();
        List<Clima> dadosInverno = new List<Clima>();
        List<Clima> dadosOutono = new List<Clima>();

        // método que recebe o nome do arquivo que esta os dados e uma lista vazia para receber os dados gerais nessa lista
        dadosClimaticos = Clima.LerDadosEpassarParaLista(nomeArquivo, dadosClimaticos);

        //instaciação das listas vazias de cada estação recebendo por argumento os dadosClimaticos separados para cada estação
        dadosVerao = Clima.DadosVerao(dadosClimaticos);
        dadosInverno = Clima.DadosInverno(dadosClimaticos);
       dadosOutono = Clima.DadosOutono(dadosClimaticos);

        // listas declaradas para receber apenas as linhas que são de determinada temperatura, lista com temp quente, lista com temp frio, lista com temp ameno
        List<Clima> Quente = new List<Clima>();
        List<Clima> Frio = new List<Clima>();
        List<Clima> Ameno = new List<Clima>();


        // SAIDA DE DADOS EXIBINDO OS DADOS APENAS NA TEMPERATURA QUENTE E EXIBINDO A QUANTIDADE DE TEMPERATURA QUENTE EM CADA ESTAÇÃO
        Console.WriteLine("----------------------------------------------");
        Quente = Clima.MaisQuente(dadosClimaticos);
        int quenteInVerao = Clima.QuantidadeQuenteEmVerao(Quente, mesesVerao);
        int quenteInInverno = Clima.QuantidadeQuenteEmInverno(Quente);
        int quenteInOutono = Clima.QuantidadeQuenteEmOutono(Quente);
        Console.WriteLine($"Quantidade de temperaturas quentes no verão:  {quenteInVerao}");
        Console.WriteLine($"Quantidade de temperaturas quentes no inverno:  {quenteInInverno}");
        Console.WriteLine($"Quantidade de temperaturas quentes no outono:  {quenteInOutono}");
        Console.WriteLine("----------------------------------------------");

        // SAIDA DE DADOS EXIBINDO OS DADOS APENAS NA TEMPERATURA FRIO E EXIBINDO A QUANTIDADE DE TEMPERATURA FRIO EM CADA ESTAÇÃO
        Console.WriteLine("----------------------------------------------");
        Frio = Clima.MaisFrio(dadosClimaticos);
        int frioInVerao = Clima.QuantidadeFrioEmVerao(Frio);
        int frioInInverno = Clima.QuantidadeFrioEmInverno(Frio);
        int frioInOutono = Clima.QuantidadeFrioEmOutono(Frio);
        Console.WriteLine($"Quantidade de temperaturas frias no verão: {frioInVerao}");
        Console.WriteLine($"Quantidade de temperaturas frias no inverno: {frioInInverno}");
        Console.WriteLine($"Quantidade de temperaturas frias no outono: {frioInOutono}");
        Console.WriteLine("----------------------------------------------");

        // SAIDA DE DADOS EXIBINDO OS DADOS APENAS NA TEMPERATURA AMENO E EXIBINDO A QUANTIDADE DE TEMPERATURA AMENO EM CADA ESTAÇÃO
        Console.WriteLine("----------------------------------------------");
        Ameno = Clima.MaisAmeno(dadosClimaticos);
        int amenoInVerao = Clima.QuantidadeAmenoEmVerao(Ameno);
        int amenoInInverno = Clima.QuantidadeAmenoEmInverno(Ameno);
        int amenoInOutono = Clima.QuantidadeAmenoEmOutono(Ameno);
        Console.WriteLine($"Quantidade de temperaturas amenas no verão: {amenoInVerao}");
        Console.WriteLine($"Quantidade de temperaturas amenas no inverno: {amenoInInverno}");
        Console.WriteLine($"Quantidade de temperaturas amenas no outono: {amenoInOutono}");
        Console.WriteLine("----------------------------------------------");
        
        // CONDICIONAIS PARA DESCOBRIR QUAL ESTAÇÃO MAIS QUENTE
        Console.WriteLine("==========================================================");
        if (quenteInVerao > quenteInInverno && quenteInVerao > quenteInOutono)
        {
            Console.WriteLine($"Estação mais quente: Verão");
            Console.WriteLine($"Quantidade de temp quentes: {quenteInVerao}");
        }
        else if (quenteInInverno > quenteInOutono){
            Console.WriteLine($"Estação mais quente: Inverno");
            Console.WriteLine($"Quantidade de temp quentes: {quenteInInverno}");
        }
        else
        {
            Console.WriteLine($"Estação mais quente: Outono");
            Console.WriteLine($"Quantidade de temp quentes: {quenteInOutono}");
        }


        // CONDICIONAIS PARA DESCOBRIR QUAL ESTAÇÃO MAIS FRIA
        //=====================================================================
        if (frioInVerao > frioInInverno && frioInVerao > frioInOutono)
        {
            Console.WriteLine($"Estação mais fria: Verão");
            Console.WriteLine($"Quantidade de temp frias: {frioInVerao}");
        }
        else if (frioInInverno > frioInOutono){
            Console.WriteLine($"Estação mais fria: Inverno");
            Console.WriteLine($"Quantidade de temp frias: {frioInInverno}");
        }
        else
        {
            Console.WriteLine($"Estação mais fria: Outono");
            Console.WriteLine($"Quantidade de temp frias: {frioInOutono}");
        }


        // CONDICIONAIS PARA DESCOBRIR QUAL ESTAÇÃO MAIS AMENO
        //==================================================================
        if (amenoInVerao > amenoInInverno && amenoInVerao > amenoInOutono)
        {
            Console.WriteLine($"Estação mais amena: Verão");
            Console.WriteLine($"Quantidade de temp amenas: {amenoInVerao}");
        }
        else if (amenoInInverno > amenoInOutono){
            Console.WriteLine($"Estação mais ameno: Inverno");
            Console.WriteLine($"Quantidade de temp amenas: {amenoInInverno}");
        }
        else
        {
            Console.WriteLine($"Estação mais fria: Outono");
            Console.WriteLine($"Quantidade de temp frias: {amenoInOutono}");
        }
        Console.WriteLine("==========================================================");
        Console.WriteLine("Fim do sistema!");
        

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


    
    //método que recebe a lista dadosClimaticos e retorna em uma lista apenas as linhas que sejam == "Quente"
    public static List<Clima> MaisQuente(List<Clima> lista) {

        List<Clima> quente = new List<Clima>();

        foreach (Clima clima in lista) {
            if (clima.Temperatura == "Quente")
            {
                quente.Add(clima);
            }
        }
        foreach (Clima n in quente) {
            Console.WriteLine(n);
        }
        return quente;
    }


    // método que recebe a lista dadosClimaticos e retorna em uma lista apenas as linhas que sejam == "Frio"
    public static List<Clima> MaisFrio(List<Clima> lista)
    {
        List<Clima> frio = new List<Clima>();

        foreach (Clima clima in lista)
        {
            if (clima.Temperatura == "Frio")
            {
                frio.Add(clima);
            }
        }
        foreach (Clima n in frio)
        {
            Console.WriteLine(n);
        }
        return frio;

    }

    // método que recebe a lista dadosClimaticos e retorna em uma lista apenas as linhas que contém a temperatura == "Ameno
    public static List<Clima> MaisAmeno(List<Clima> lista)
    {
        List<Clima> ameno = new List<Clima>();

        foreach (Clima clima in lista)
        {
            if (clima.Temperatura == "Ameno")
            {
                ameno.Add(clima);
            }
        }
        foreach (Clima n in ameno)
        {
            Console.WriteLine(n);
        }
        return ameno;
    }   


    // método que recebe a lista com todas as linhas que contém a temperatura "Quente" e soma quantas temperaturas "Quente" tem na estação verão
    public static int QuantidadeQuenteEmVerao(List<Clima> lista, string[] mesesVerao)
    {   
        int qntdQuenteEmVerao = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesVerao)
            {
                if (clima.Mes == i)
                {
                    qntdQuenteEmVerao++;
                    break;
                }
            }
        }

        return qntdQuenteEmVerao;
    }


    // método que recebe a lista com todas as linhas que contém temperatura "Frio" e soma quantas temperaturas "Frio" tem na estação verão
    public static int QuantidadeFrioEmVerao(List<Clima> lista, string[] mesesVerao)
    {
        int qntdFrioEmVerao = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesVerao)
            {
                if (clima.Mes == i)
                {
                    qntdFrioEmVerao++;
                    break;
                }
            }
        }
        return qntdFrioEmVerao;
    }


        // método que recebe a lista com todas as linhas que contém temperatura "Ameno" e soma quantas temperaturas "Ameno" tem na estação verão
    public static int QuantidadeAmenoEmVerao(List<Clima> lista, string[] mesesVerao)
    {
        int qntdAmenoEmVerao = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesVerao)
            {
                if (clima.Mes == i)
                {
                    qntdAmenoEmVerao++;
                    break;
                }
            }
        }
        return qntdAmenoEmVerao;
    }


    // método que recebe a lista com as linhas que contém a temperatura == "Quente" e soma quantas Temperaturas "Quente" tem na estação inverno
    public static int QuantidadeQuenteEmInverno(List<Clima> lista, string[] mesesInverno)
    {
        int qntdQuenteEmInverno = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdQuenteEmInverno++;
                    break;
                }
            }
        }
        return qntdQuenteEmInverno;
    }

    
    // método que recebe a lista com as linhas que contém a temperatura == "Frio" e soma quantas Temperaturas "Frio" tem na estação inverno
    public static int QuantidadeFrioEmInverno(List<Clima> lista, string[] mesesInverno)
    {
        int qntdFrioEmInverno = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdFrioEmInverno++;
                    break;
                }
            }
        }
        return qntdFrioEmInverno;
    }


    // método que recebe a lista com linhas que contém a temperatura == "Ameno" e soma quantas Temperaturas "Amenos" tem na estação inverno
    public static int QuantidadeAmenoEmInverno(List<Clima> lista, string[] mesesInverno)
    {
        int qntdAmenoEmInverno = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdAmenoEmInverno++;
                    break;
                }
            }
        }
        return qntdAmenoEmInverno;
    }


    // método que recebe a lista com linhas que contém a temperatura == "Quente" e soma quantas Temperaturas "Quente" tem na estação outono
    public static int QuantidadeQuenteEmOutono(List<Clima> lista, string[] mesesOutono)
    {
        int qntdQuenteEmOutono = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdQuenteEmOutono++;
                    break;
                }
            }
        }
        return qntdQuenteEmOutono;
    }


    // método que recebe a lista com linhas que contém a temperatura == "Frio" e soma quantas Temperaturas "Frio" tem na estação Outono
    public static int QuantidadeFrioEmOutono(List<Clima> lista, string[] mesesOutono)
    {
        int qntdFrioEmOutono = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdFrioEmOutono++;
                    break;
                }
            }
        }
        return qntdFrioEmOutono;
    }

    // método que recebe a lista com linhas que contém a temperatura == "Ameno" e soma quantas Temperaturas "Ameno" tem na estação Outono
    public static int QuantidadeAmenoEmOutono(List<Clima> lista, string[] mesesOutono)
    {
        int qntdAmenoEmOutono = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdAmenoEmOutono++;
                    break;
                }
            }
        }
        return qntdAmenoEmOutono;
    }
}

