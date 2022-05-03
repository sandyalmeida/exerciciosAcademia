// Escreva um programa em C# e no Visual Studio para calcular a média aritmetica entre quatro numeros quaisquer
float numero1;
float numero2;
float numero3;
float numero4;
float media_aritmetica;

/* ESCREVE O PRIMEIRO NUMERO*/
Console.WriteLine("digite o primeiro numero");
/* ELE LÊ O QUE ESTA ESCRITO NA TELA E ATRIBUI A VARIAVEL NUMERO1*/
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero");
numero2 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o terceiro numero");
numero3 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o quarto numero");
numero4 = float.Parse(Console.ReadLine());

/* A MEDIA ARITMETICA É A SOMA DE TODOS OS NUMEROS DIVIDIDOS POR ELES*/

media_aritmetica = numero1 + numero2 + numero3 + numero4;
media_aritmetica = media_aritmetica / 4;
Console.WriteLine(media_aritmetica);
