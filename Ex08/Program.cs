//Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
//A fórmula da conversão é F=(9*C+160)/ 5.

float graus_celsius;
float graus_Fahrenheit;

Console.WriteLine("digite o a temperatura em Celsius");
graus_celsius = float.Parse(Console.ReadLine());

graus_Fahrenheit = (9 * graus_celsius + 160) / 5;
Console.WriteLine("resultado em fahrenheit: " + graus_Fahrenheit);
