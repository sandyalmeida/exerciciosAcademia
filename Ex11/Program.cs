//Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um 
//representa em relação ao total de eleitores.

int eleitores;
int votos_brancos;
int votos_nulos;
int votos_validos;
float percentual_brancos;
float percentual_nulos;
float percentual_validos;

Console.WriteLine("numero de eleitores");
eleitores = int.Parse(Console.ReadLine());

Console.WriteLine("votos brancos");
votos_brancos = int.Parse(Console.ReadLine());

Console.WriteLine("votos nulos");
votos_nulos = int.Parse(Console.ReadLine());

Console.WriteLine("votos validos");
votos_validos = int.Parse(Console.ReadLine());

percentual_brancos = (votos_brancos * 100) / eleitores;
percentual_nulos = (votos_nulos * 100) / eleitores;
percentual_validos = (votos_validos * 100) / eleitores;


Console.WriteLine("percentual branco: " + percentual_brancos);

Console.WriteLine("percentual nulo: " + percentual_nulos);

Console.WriteLine("percentual validos: " + percentual_validos);




