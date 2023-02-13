using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula24
{
    //quando for static, todos os metodos precisam ser static
    static void Main()
    {
        texto();
        soma(2, 2);
        soma2(4, 4);
    }

    static void texto()
    {
        Console.WriteLine("Texto teste método");
    }

    static void soma(int n1, int n2)
    {
        int res = n1 + n2;
        Console.WriteLine($"A soma de {n1}+{n2} é: {res}");
    } 

    static int soma2(int n1, int n2)
    {
        int res = n1 + n2;
        return res;
    }




}
