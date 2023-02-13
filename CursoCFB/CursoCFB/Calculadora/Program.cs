using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula24
{
    
    static void Main()
    {
        float numero1;
        float numero2;
        float resultado;
        char operacao;

        inicio: Console.Clear();

        Console.WriteLine("Digite o primeiro número: ");
        numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        numero2 = float.Parse(Console.ReadLine());

        Console.WriteLine("Qual operação você quer fazer: (a)Soma, (b)Subtração, " +
        "(c)Multiplicação ou (d)Divisão");
        operacao = char.Parse(Console.ReadLine().ToUpper());

        switch (operacao)
        {
            case 'A':
                resultado = numero1 + numero2;
                Console.WriteLine($"O resultado da soma é: {resultado}");
                break;

            case 'B':
                resultado = numero1 - numero2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                break;

            case 'C':
                resultado = numero1 * numero2;
                Console.WriteLine($"O resultado da multiplicação é: {resultado}");
                break;

            case 'D':
                if (numero1 == 0 || numero2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por 0");
                } else
                {
                    resultado = numero1 / numero2;                
                    Console.WriteLine($"O resultado da divisão é: {resultado}");
                }
                break;
        }

        Console.WriteLine("Deseja fazer uma nova consulta?(s)-Sim ou (n)-Não");
        operacao = char.Parse(Console.ReadLine().ToUpper());
        switch (operacao)
        {
            case 'S':
                goto inicio;
                break;
            case 'N':
                Console.Clear();
                Console.WriteLine("Fim do programa"); ;
                break;
        }
    }

}
