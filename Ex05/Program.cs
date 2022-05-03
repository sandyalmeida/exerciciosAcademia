//Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
//(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível 
//consumido para percorrê-la (medido em l).

float consumo_medio;
float distancia_percorrida;
float volume;

distancia_percorrida = float.Parse(Console.ReadLine());
volume = float.Parse(Console.ReadLine());
consumo_medio = distancia_percorrida / volume;
Console.WriteLine(consumo_medio);