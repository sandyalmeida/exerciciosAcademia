//Uma loja vende seus produtos no sistema de entrada mais duas prestações, sendo a entrada maior 
//do que ou igual às duas prestações, que devem ser iguais, inteiras e as maiores possíveis. 
//Por exemplo, se o valor da mercadoria for R$ 270,00, a entrada e as duas prestações são iguais a R$ 90,00;
//se o valor da mercadoria for R$ 302,75 a entrada é de R$ 102,75 e as duas prestações são iguais a R$ 100,00.
//Escreva um programa em C# e no Visual Studio que receba o valor da mercadoria e forneça o valor 
//da entrada e das duas prestações, de acordo com as regras acima. 
//Observe que uma justificativa para a adoção desta regra é que ela facilita a confecção e o 
//conseqüente pagamento dos boletos das duas prestações.

/* DECLARAÇÂO DAS VARIÁVEIS UTILIZADAS NO CÓDIGO */
float valor_mercadoria;
float entrada;
int parcelas;

/* LEITURA / RECEBIMENTO DA VARIÁVEL MERCADORIA */
Console.WriteLine("Digite o valor da mercadoria: ");
valor_mercadoria = float.Parse(Console.ReadLine());

/* DIVIDE O VALOR DA MERCADORIA POR 3 E ATRIBUI SOMENTE A PARTE INTEIRA NA VARIÁVEL parcelas */
parcelas = (int)(valor_mercadoria / 3);

/* SUBTRAI O VALOR DA MERCADORIA POR (PARCELAS * 2) PARA ENCONTRAR O RESTANTE / ENTRADA E ATRIBUI NA VARIÁVEL entrada */
entrada = valor_mercadoria - (parcelas * 2);

/* EXIBE / ESCREVE O VALOR DA ENTRADA NA TELA (VARIÁVEL entrada) */
Console.WriteLine("Valor da entrada: " + entrada);

/* EXIBE / ESCREVE O VALOR DAS PARCELAS NA TELA (VARIÁVEL parcelas) */
Console.WriteLine("Valor das parcelas: " + parcelas);
