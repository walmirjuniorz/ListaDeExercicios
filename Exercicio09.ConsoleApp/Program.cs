/*  Exercicio 09
    Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
    valores do cálculo de A! e o seu resultado.
        a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
        b. Pesquise sobre “fatorial” 
*/

int a, fatorial = 1;

Console.Write("Digite um valor para A: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write(a + "!=");

for (int i = a; i >= 1; i--)
{
    Console.Write(i + " ");
    fatorial *= i;

    if (i > 1)
    {
        Console.Write("X ");
    }
}
Console.Write("=" + fatorial);
Console.ReadLine();
