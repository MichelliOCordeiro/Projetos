using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;
        string produto = "Pastel";

        valorVenda = valorCompra + (valorCompra * lucro);

        //o 15 é o espaço de tabulação que ficara e o C e P é o formato da variavel 
        Console.WriteLine("Produto..........:{0,15}", produto);
        Console.WriteLine("Val.Compra.......:{0,15:c}", valorCompra);
        Console.WriteLine("Lucro............:{0,15:p}", lucro);
        Console.WriteLine("Val.Venda........:{0,15:c}", valorVenda);

    }
}

