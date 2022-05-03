//Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
//preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
//vendidas pelo vendedor, calcule e mostre: o salário do empregado


/* DECLARA AS VARIÁVEIS USADAS NO CÓDIGO */
float salario_minimo;
float preco_custo;
int bicicletas_vendidas;
float salario_empregado;
float preco_venda;
float valor_comissao_por_bicicleta;
float total_comissao;

/* REALIZA A LEITURA/ENTRADA DA VARIÁVEL salario_minimo */
Console.WriteLine("salario minimo: ");
salario_minimo = float.Parse(Console.ReadLine());

/* REALIZA A LEITURA/ENTRADA DA VARIÁVEL preco_custo */
Console.WriteLine("preco de custo: ");
preco_custo = float.Parse(Console.ReadLine());

/* REALIZA A LEITURA/ENTRADA DA VARIÁVEL bicicletas_vendidas */
Console.WriteLine("bicicletas vendidas: ");
bicicletas_vendidas = int.Parse(Console.ReadLine());

/* ACRESCENTA 50% AO PRECO DE CUSTO DA BICICLETA PARA ENCONTRAR O PREÇO DE VENDA E ATRIBUI NA VARIÁVEL preco_venda */
preco_venda = preco_custo * 1.5f;

/* CALCULA OS 15% DE COMISSÂO DO FUNCIONÁRIO POR BICICLETA VENDIDA E ATRIBUI NA VARIÁVEL valor_comissao */
valor_comissao_por_bicicleta = preco_venda * 0.15f;

/* MULTIPLICA O SALARIO MINIMO POR 2 E ATRIBUI NA VARIÁVEL salario_empregado */
salario_empregado = salario_minimo * 2;

/* MULTIPLICA O VALOR DA COMISSAO POR VENDA DE BICILETA PELO VALOR DE BICICLETAS VENDIDAS PARA ACHARMOS O VALOR TOTAL DA COMISSAO E ATRIBUI NA VARIÁVEL total_comissao */
total_comissao = valor_comissao_por_bicicleta * bicicletas_vendidas;

/* SOMA O SALARIO EMPREGADO COM O TOTAL DE COMISSAO E ATRIBUI NA VARIÁVEL salario_empregado */
salario_empregado = salario_empregado + total_comissao;

/* EXIBE O SALÀRIO CALCULADO CONTIDO NA VARIÁVEL salario_empregado */
Console.WriteLine("Salário empregado é de: " + salario_empregado);

