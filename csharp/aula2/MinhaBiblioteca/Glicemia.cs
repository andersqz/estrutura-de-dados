
using System.ComponentModel;
using System.Runtime.InteropServices.Swift;

class Glicemia
{
    public int Valor;
    public string Data;
    public string Hora;

    public Glicemia(int valor, string data, string hora)
    {
        this.Valor = valor;
        this.Data = data;
        this.Hora = hora;
    }

    public override string ToString()
    {
        return $"Valor glicemia: {this.Valor}. Data: {this.Data}. Hora: {this.Hora}";
    }

    public CalcularMedia(List<int> lista)
    {
        int soma = 0;
        foreach (int item in lista)
        {
            soma += int.Parse((item.Valor));
        }
    }

    public static double CalcularMediana(List<Glicemia> lista)
    {
        if (lista == null || lista.Count == 0)
            return 0;

        List<int> valores = lista
    }
}