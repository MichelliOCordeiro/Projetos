//adicionar links de pesquisa

//sintaxe declarar variavel - tipo (int, string, float, object), nome (nao pode conter caracteres especiais, espaços e nao pode
//iniciar com numero, caracterer especial so nao no inicio).
int idade; //declarando variavel
idade = 0; //inicializando a variavel
int idade2 = 1; //declarando e inicializando na mesma linha de comando

//todo metodo que retorna valor pode ter o seu resultado guardado dentro de uma variavel
string texto;
//Console.ReadLine();
texto = MetodoBase2("texto1", "texto2");
Console.WriteLine(texto);

//sintaxe declarar metodo - visibilidade (public, private, protect, static), retorno (void, int, string, float, object), nome do metodo (batata, feijao)
//parametro (string valor1, string valor2). É o contrato do metodo
//retorno void, nao retorna nada. Mas ele pode retornar um valor se ele nao for void
//classe é o contrato do tipo object
static void MetodoBase()
{
    
}

static string MetodoBase2(string texto1, string texto2)
{
    Console.WriteLine(texto1);
    Console.WriteLine(texto2);
    return "informação";
}

//é bom utilizar quando eu sei exatamente quantas posições tera
//na lista e no dicionario nao tem limite
string[] paragrafo = new string[10];
//preenchendo a posição do array
paragrafo[0] = "Douglas"; 
paragrafo[3] = "Bob"; 
//para chamar a posição do array
Console.WriteLine(paragrafo[0]);
paragrafo.ToList();

//dicionario chave / valor -- nao confundir chave com posicao
Dictionary<int, string> dicionario = new Dictionary<int, string>();
//adicionar valor no dicionario
dicionario.Add(1, "Chocolate");
dicionario.Add(27, "Bob");
dicionario.Add(385, "Dylan");
Console.WriteLine(dicionario[385]);
Console.WriteLine();
//ler info no dicionario
// esse foreach so funciona para dicionario
//foreach (var (key, value) in dict)
//{
//    Console.WriteLine(key + " : " + value);
//}
//    }
//}

///*
//    Resultado:

//    chave1: valor1
//    chave2 : valor2
//    chave3: valor3
//*/

//declarar uma lista
List<string> animais = new List<string>();
//para adicionar
animais.Add("Cachorro");
animais.Add("Gato");
animais.Add("Papagaio");
animais.Add("Papagaio");
//para remover um item -- escrever exatamente igual -- ele so remove 1 valor quando for igual
//animais.Remove("Papagaio");
//remover pela posição
//animais.RemoveAt(2);
//animais.RemoveAll(e => e == "Papagaio");
//sempre se atentar que o where é um enumerable, tem que converter em lista
List<string> animais2 = animais.Where(e => e == "Papagaio").ToList();
Console.WriteLine();

//laços / looping (for, while, do while, foreach)
//o primeiro é o contador, a partir do valor informado. o segundo é ate quando vai fazer o loop (ate o 10),
//e o terceiro é um incremento
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

//percorrendo lista
//count com o parentese é usado para quando vc nao sabe o valor
for (int i = 0; i < animais.Count; i++)
{
    Console.WriteLine(animais[i]);
}
Console.WriteLine();
Console.WriteLine();

//while
var contador = 0;
var nome = "Papagaio";
while (nome != "Papagaio")
{
    Console.WriteLine(animais[contador]);
    nome = animais[contador];
    contador++;
}

//do while
//sempre executa uma vez no minimo
do
{
    Console.WriteLine(animais[contador]);
    nome = animais[contador];
    contador++;

} while (nome != "Papagaio");

//foreach
foreach (var item in animais)
{  
    Console.WriteLine(item);

}
animais.ForEach(e => Console.WriteLine(e));
//se só tem uma operação que nao seja de atribuição, usar o foreach de uma linha 
// nao pode ser atribuição, item = 0, nao pode ser isso
Console.WriteLine();






