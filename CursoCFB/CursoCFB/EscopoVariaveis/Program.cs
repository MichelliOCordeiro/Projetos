using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudosCSharp
{
    class Aula04
    {
        //isso é uma variavel global, pode ser usada em qualquer escopo
        static int num = 10;

        static void Main()
        {
            int num2 = 0;
            Console.WriteLine(num);
        }

        void teste()
        {
            //int num3 = 0;
            //Console.WriteLine(num);
            //se nao tivesse a variavel dentro da classe, aqui ira dar erro, pois, a variavel num é do metodo main, isso se chamada variavel local
            //Console.WriteLine(num);
        }
    }
}


