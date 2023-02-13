using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula17
{
    static void Main()
    {
        int n1, n2, n3, n4;
        //forma mais facil de fazer isso:
        //sintaxe: tipo, [], nome, que é igual a new e [5] quantos indices terá
        int[] n = new int[5];
        //outra forma, aqui nao conta como indice, mas como numero de elementos
        int[] num = new int[3]{ 2, 4, 6};

        //para adicionar valores:
        n[3] = 22;
        n[4] = 44;

        Console.WriteLine(n[3]);

        Console.WriteLine(num[2]);
    }
}
