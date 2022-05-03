//Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
//isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem 
//de IPI (única) a ser acrescentada. 

int codigo_A;
int codigo_B;
int quantidade_pecasA;
int quantidade_pecasB;
float valor_unitarioA;
float valor_unitarioB;
float ipi;
float totalA;
float totalB;

Console.WriteLine(" digite o codigo A");
codigo_A = int.Parse(Console.ReadLine());
Console.WriteLine(" digite o codigo B");
codigo_B = int.Parse(Console.ReadLine());
Console.WriteLine(" digite a quantidade de pecas A");
quantidade_pecasA = int.Parse(Console.ReadLine());
Console.WriteLine(" digite a quantidade de pecas B");
quantidade_pecasB = int.Parse(Console.ReadLine());
Console.WriteLine(" digite o valor unitario A");
valor_unitarioA = float.Parse(Console.ReadLine());
Console.WriteLine(" digite o valor unitario B");
valor_unitarioB = float.Parse(Console.ReadLine());
Console.WriteLine(" digite o valor do ipi");
ipi = float.Parse(Console.ReadLine());
totalA = valor_unitarioA * (ipi / 100);
totalA = totalA * quantidade_pecasA;
totalB = valor_unitarioB * (ipi / 100);
totalB = totalB * quantidade_pecasB;
Console.WriteLine(" o preco final do parafuso a é" + totalA);
Console.WriteLine(" o preco final do parafuso b é" + totalB);



