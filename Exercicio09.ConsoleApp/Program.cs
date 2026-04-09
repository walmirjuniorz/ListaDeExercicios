/*
Escreva um algoritmo que leia um valor inicial A e imprima a sequência de
valores do cálculo de A! e o seu resultado.
    a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
    b. Pesquise sobre “fatorial” 
*/

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.Write("FizzBuzz ");
    }
    else if (i % 3 == 0)
    {
        Console.Write("Fizz ");
    }
    else if (i % 5 == 0)
    {
        Console.Write("Buzz ");
    }
    else
    {
        Console.Write(Convert.ToString(i) + "");
    }
}