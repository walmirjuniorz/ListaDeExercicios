/*Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor
que C.
*/

Console.Write("Informe o valor de A: ");
double valorA = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor de B: ");
double valorB = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor de C: ");
double valorC = Convert.ToDouble(Console.ReadLine());

double somaAB = valorA + valorB;

if (somaAB < valorC)
{
    Console.WriteLine("A soma é menor que C");
}
else if (somaAB > valorC)
{
    Console.WriteLine("A soma é maior que C");
}
else
{
    Console.WriteLine("A soma é igual ao valor de C");
}
