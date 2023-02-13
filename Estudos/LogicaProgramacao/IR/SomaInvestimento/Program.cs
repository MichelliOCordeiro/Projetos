using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        double rendimento = 10;
        double resultado = 0;
        int mes = 12;

        while (mes <= 12)
        {
            resultado = investimento + rendimento * mes;

            mes++;

            //investimento = investimento + 10;
            //Console.WriteLine($"No mês { mes } você tem {investimento}");

            //mes++;            
        }
        Console.WriteLine(resultado);

        Console.WriteLine("Tecle para fechar...");
        Console.ReadLine();
    }
}

