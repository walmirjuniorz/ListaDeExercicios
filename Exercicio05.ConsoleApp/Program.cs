/*  Exercicio 05
    Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno
*/

Console.Write("Informe a nota um: ");
double notaUm = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a nota dois: ");
double notaDois = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o peso um: ");
double pesoUm = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o peso dois: ");
double pesoDois = Convert.ToDouble(Console.ReadLine());

double resultadoUm = notaUm * pesoUm;
double resultadoDois = notaDois * pesoDois;
double somaPesos = pesoUm + pesoDois;

double somaResultados = resultadoUm + resultadoDois;
double mediaFinal = somaResultados / somaPesos;

Console.Write($"A média ponderada é: {mediaFinal}");

