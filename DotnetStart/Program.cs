using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");
Console.WriteLine("Teste dotnet");

//Declaração de variáveis
int variavelInt = 31;
var variavelInt2 = 10;

decimal variavelDecimal = 10.5m;
float variavelFloat = 10.5f;
bool variavelBool = true;

var variavelString = "10";
var variavelString2 = "10";

Console.WriteLine(variavelInt + variavelInt2);
Console.WriteLine(variavelString + variavelString2);


if (variavelInt == 10)
{
    Console.WriteLine("É 10");
}
else
{
    Console.WriteLine("Não é 10");
}

//Executa um bloco de código enquanto a condição for verdadeira
while (variavelInt <= 30)
{
    Console.WriteLine(variavelInt);
    variavelInt++;
}

//Executa um bloco de código enquanto a condição for verdadeira (mas executa pelo menos uma vez o bloco)
do
{
    Console.WriteLine(variavelInt);
    variavelInt++;

} while (variavelInt <= 30);

//Percorre um intervalo de valores

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

var lista = new int[] { 1, 2, 3, 4, 5, 6, 7, 45, 97 };

//Percorre uma lista de uma coleção de itens	
foreach (var item in lista)
{
    Console.WriteLine("Valor do item: " + item);
}


