//Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
//o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas. 
//Calcule o salário total do vendedor. Escreva o número do vendedor e o salário total do vendedor.

int numero_vendedor;
float salario_fixo;
int total_vendas;
float percentual_ganho;
float total_vendedor;
numero_vendedor = int.Parse(Console.ReadLine());
salario_fixo = float.Parse(Console.ReadLine());
total_vendas = int.Parse(Console.ReadLine());
percentual_ganho = float.Parse(Console.ReadLine());
total_vendedor = total_vendas * (percentual_ganho / 100);
total_vendedor = total_vendedor + salario_fixo;
Console.WriteLine(numero_vendedor + " salario total: " + total_vendedor);

