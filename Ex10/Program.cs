//Um programa para gerenciar os saques de um caixa eletrônico deve possuir algum mecanismo 
//para decidir o número de notas de cada valor que deve ser disponibilizado para o cliente que 
//realizou o saque. Um possível critério seria o da “distribuição ótima” no sentido de que as 
//notas de menor valor fossem distribuídas em número mínimo possível. 
//Por exemplo, se a quantia solicitada fosse R$ 87,00 o programa deveria indicar uma nota de R$ 50,00,
//três notas de R$ 10,00, uma nota de R$ 5,00 e duas notas de R$ 1,00. 
//Escreva um programa que receba o valor da quantia solicitada e retorne a distribuição das notas 
//de acordo com o critério da “distribuição ótima”.

/* DECLARAÇÔES DAS VARIÁVEIS UTILIZADAS */
int quantia;
int notas_50, notas_10, notas_5, notas_1;

/* INICIALIZA / ZERA AS VARIÁVEIS QUE SÃO USADAS NO CÓDIGO */
notas_50 = 0;
notas_10 = 0;
notas_5 = 0;
notas_1 = 0;

/* SOLICITA E RECEBE A QUANTIA E ATRIBUI NA VARIÁVEL quantia */
Console.WriteLine("Digite a quantia desejada: ");
quantia = int.Parse(Console.ReadLine());

/* DIVIDE A QUANTIA POR 50 PARA ENCONTRAR A QUANTIDADE DE NOTAS DE 50 REAIS */
notas_50 = quantia / 50;

/* OBTÉM O RESTO DA DIVISÃO POR 50 PARA SABER QUANTO DE DINHEIRO AINDA SOBRA APÓS A RETIRADA DAS NOTAS DE 50 E ATRIBUI DE VOLTA NA VARIÁVEL quantia */
quantia = quantia % 50;

/* DIVIDE A QUANTIA POR 10 PARA ENCONTRAR A QUANTIDADE DE NOTAS DE 10 REAIS */
notas_10 = quantia / 10;

/* OBTÉM O RESTO DA DIVISÃO POR 10 PARA SABER QUANTO DE DINHEIRO AINDA SOBRA APÓS A RETIRADA DAS NOTAS DE 10 E ATRIBUI DE VOLTA NA VARIÁVEL quantia */
quantia = quantia % 10;

/* DIVIDE A QUANTIA POR 5 PARA ENCONTRAR A QUANTIDADE DE NOTAS DE 5 REAIS */
notas_5 = quantia / 5;

/* OBTÉM O RESTO DA DIVISÃO POR 5 PARA SABER QUANTO DE DINHEIRO AINDA SOBRA APÓS A RETIRADA DAS NOTAS DE 5 E ATRIBUI DE VOLTA NA VARIÁVEL quantia */
quantia = quantia % 5;

/* DIVIDE A QUANTIA POR 1 PARA ENCONTRAR A QUANTIDADE DE NOTAS DE 1 REAIS */
notas_1 = quantia / 1;

/* OBTÉM O RESTO DA DIVISÃO POR 1 PARA SABER QUANTO DE DINHEIRO AINDA SOBRA APÓS A RETIRADA DAS NOTAS DE 1 E ATRIBUI DE VOLTA NA VARIÁVEL quantia */
quantia = quantia % 1;

Console.WriteLine("A quantidade de notas de 50 eh: " + notas_50);
Console.WriteLine("A quantidade de notas de 10 eh: " + notas_10);
Console.WriteLine("A quantidade de notas de 5 eh: " + notas_5);
Console.WriteLine("A quantidade de notas de 1 eh: " + notas_1);
