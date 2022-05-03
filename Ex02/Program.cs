// Escreva um programa em C# e no Visual Studio para calcular a média aritmetica entre quatro numeros quaisquer
float numero1;
float numero2;
float numero3;
float numero4;
float media_aritmetica;
Console.WriteLine("digite o primeiro numero");
numero1 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o segundo numero");
numero2 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o terceiro numero");
numero3 = float.Parse(Console.ReadLine());
Console.WriteLine("digite o quarto numero");
numero4 = float.Parse(Console.ReadLine());

media_aritmetica = numero1 + numero2 + numero3 + numero4;
media_aritmetica = media_aritmetica / 4;
Console.WriteLine(media_aritmetica);
