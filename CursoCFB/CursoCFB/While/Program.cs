using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula20
{
    static void Main()
    {
        //o while é usado quando nao sei até quando, não sei qual é quantidade final.
        //Quando tiver a qtde final, usar o for
        int[] num = new int[10];

        //no while precisa ser colocado o contador: i = 0; e a condição fica dentro dele
        //sintaxe: variavel contador + condição dentro do while
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine("Texto");
            i++;
        }

        //sempre se atentar neste caso, pois o i pega a posição, e não pega o indice 0,
        //ou seja, ele vai começar contando a posição 0 como numero 1
        while (i < num.Length)
        {
            num[i] = 0;
            Console.WriteLine(num[i]);
            i++;
        }
        Console.WriteLine("Fim do programa");

        int i3 = num.Length - 1;
        while (i3 > 0)
        {
            num[i3] = 0;
            Console.WriteLine(num[i3]);
            i3--;
        }
        Console.WriteLine("Fim");
    }
}
