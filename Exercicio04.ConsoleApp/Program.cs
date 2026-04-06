/*
4. Crie um programa para calcular o salário total de um vendedor.
Deverá ser informado o salário base e o total de vendas. 
A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.
*/

Console.Write("Informe o salário base: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o total de vendas: ");
double totalVendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe percentual da comissão: ");
double percentual = Convert.ToDouble(Console.ReadLine());

percentual = percentual / 100;
double comissao = totalVendas * percentual;
double salarioTotal = salario + comissao;

Console.Write($"O total do seu salário é: {salarioTotal}");
