/*  Exercicio 03
    Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit
*/

Console.WriteLine("--------------------------------------------");
Console.WriteLine("CONVERSOR DE TEMPERATURA");
Console.WriteLine("--------------------------------------------");
Console.Write("Digite o valor em graus Celsius (°C): ");
double celsius = Convert.ToDouble(Console.ReadLine());

double calculo = celsius * 1.8;
double resultado = calculo + 32;

Console.WriteLine("--------------------------------------------");
Console.WriteLine("Resultado da conversão: ");
Console.WriteLine($"A temperatura em Fahrenheit é: {resultado}°F ");
Console.WriteLine("--------------------------------------------");

