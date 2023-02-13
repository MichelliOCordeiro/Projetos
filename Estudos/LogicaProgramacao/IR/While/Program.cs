using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        int mes = 1;

        while (mes <=12)
        {
            investimento = investimento + 10;
            Console.WriteLine($"No final de 1 ano você terá o valor total de {investimento * 12}");

            mes++;

            //investimento = investimento + 10;
            //Console.WriteLine($"No mês { mes } você tem {investimento}");

            //mes++;            
        }

        Console.WriteLine("Tecle para fechar...");
        Console.ReadLine(); 
    }
}
