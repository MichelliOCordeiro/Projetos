using System;

class Programa
{
    static void Main(string[] args)
    {
        //double investimento = 1000;

        //for (int mes = 5; mes <= 12; mes++)
        //{
        //    investimento *= 0.005;
        //    Console.WriteLine($"No mês {mes} você tem {investimento}");
        //}

        //Console.WriteLine("Tecle para fechar...");
        //Console.ReadLine();

        //double fatorRendimento = 1.0005;
        //double investimento = 1000;

        //for (int anos = 1; anos <= 5; anos++)
        //{
        //    for (int mes = 1; mes <= 12; mes++)
        //    {
        //        investimento *= fatorRendimento;
        //    }
        //}
        //Console.WriteLine($"Depois de 5 anos você terá R$ {investimento}");

        //usando break no for

            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    if ( coluna > linha)
                    {
                        break;
                    }
                    Console.Write(coluna+1);
                }
                Console.WriteLine();
            }
        
    }
}

