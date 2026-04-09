/* Exercicio 01
    1. Crie um programa para calcular o volume de uma caixa retangular

    Multiplique o comprimento, a largura e a altura 
    (Fórmula: V = C . L . A) Caixa: 50 cm (comprimento) x 30 cm (largura) x 20 cm (altura).
*/

Console.Write("Digite o comprimento da caixa retangular: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a largura da caixa retangular: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a altura da caixa retangular: ");
double altura = Convert.ToDouble(Console.ReadLine());

double volume = comprimento * largura * altura;

Console.WriteLine($"O volume da caixa é: {volume:F2} cm");

Console.ReadLine();