//Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
//forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.

string dia;
string mes;
int ano;
int ano_Dois_Digitos;

Console.WriteLine("** insira a data no formato dia mes e ano **");

dia = (Console.ReadLine());

mes = (Console.ReadLine());
ano = int.Parse(Console.ReadLine());
Console.WriteLine(ano + mes + dia);
ano_Dois_Digitos = ano % 100;

Console.WriteLine(ano_Dois_Digitos + mes + dia);