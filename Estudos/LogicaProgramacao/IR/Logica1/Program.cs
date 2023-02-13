using System;
using System.Globalization;

class Programa
{
    static void Main(string[] args)
    {
        string computador = "computador";
        string tv = "TV";
        double produto1 = 210157780.01;
        decimal produto2 = 1830;
        int idade = 30;
        int codigo = 5291;
        char genero = 'F';

        Console.WriteLine($"O produto {computador} custa {produto1.ToString("C2", CultureInfo.CurrentCulture)}");
        Console.WriteLine($"O produto {tv} custa R$ {produto2}");
        Console.WriteLine($"Código = {codigo}");
        Console.WriteLine($"Dados da pessoa: genero {genero} e idade {idade}");

    }
}
