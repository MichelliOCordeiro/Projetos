class Programa
{
    static void Main(string[] args)
    {
        //for (int multiplo = 0; multiplo < 100; multiplo++)
        //{
        //        if(multiplo % 3 == 0)
        //        {
        //        Console.WriteLine(multiplo);
        //        }            
        //}

        // Nesse exercício opcional, o seu desafio é imprimir os fatoriais de 1 a 10!  Você se lembra do fatorial? Não? Sem problemas, seguem as regras:
        //O fatorial de 0 é 1.
        //O fatorial de 1 é(0!) * 1 = 1.
        
        int fatorial = 1;

        for (int n = 1; n < 11; n++)
        {
            fatorial *= n;
            Console.WriteLine($"Fatorial de {n} = {fatorial}");
        }
    }
}
