//Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível é de R$6,90, escreva um algoritmo para ler a 
//marcação do odômetro (marcador de quilometragem) no início do dia, a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido
//dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.
//Fórmulas: Total quilometragem = marcação odômetro final do dia - marcação odômetro inicio do dia 
//Média do consumo = Total quilometragem/ quantidade de combustível gasto

//Lucro do dia = Valor total recebido - (quantidade de combustível gasto * 6,90)

float preco_combustivel = 6.90f;
float odometro_inicio;
float odometro_fim;
float litros_combustivel;
float total_km;
float valor_total;
float media_consumo;
float lucro_dia;



Console.WriteLine("odometro inicio");
odometro_inicio = float.Parse(Console.ReadLine());

Console.WriteLine("odometro fim");
odometro_fim = float.Parse(Console.ReadLine());

Console.WriteLine("litros combustivel");
litros_combustivel = float.Parse(Console.ReadLine());

Console.WriteLine("valor total");
valor_total = float.Parse(Console.ReadLine());

total_km = odometro_fim - odometro_inicio;

media_consumo = total_km / litros_combustivel;

lucro_dia = valor_total - (litros_combustivel * 6.90f);



Console.WriteLine("media do consumo: " + media_consumo);


Console.WriteLine("lucro do dia: " + lucro_dia);
