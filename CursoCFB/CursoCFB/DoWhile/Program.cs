using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Aula20
{
    static void Main()
    {
        string senha = "123";
        string senhaCorreta;
        int tentativas=0;

        //o do é a iteração que executa pelo menos uma vez,ao contrario do while
        //se a condição ja for aceita, ele nem chega a executar
        do
        {
            Console.Clear();
            Console.WriteLine("Digite a senha: ");
            senhaCorreta = Console.ReadLine();
            tentativas++;
        } while (senha != senhaCorreta);
            Console.Clear();
            Console.WriteLine($"Senha correta, tentativas: {tentativas}");
    }
}
