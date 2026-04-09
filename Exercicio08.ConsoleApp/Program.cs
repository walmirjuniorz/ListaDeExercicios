/*  Exercicio 08
    Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.
*/

Console.Write("Digite o número: ");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Seu número é Par.");
}
else
{
    Console.WriteLine("Seu número é Ímpar.");
}
