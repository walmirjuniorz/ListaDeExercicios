/*
2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma
viagem.
    O programa deve solicitar ao usuário:
        a. A quilometragem inicial do veículo no início da viagem.
        b. A quilometragem final ao término da viagem.
        c. A quantidade de combustível consumida durante a viagem (em litros).
*/

Console.Write("Qual o KM inicial?: ");
double kmInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual o KM Final?: ");
double kmFinal = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantos litros de combústivel foram consumidos?: ");
double litrosConsumidos = Convert.ToDouble(Console.ReadLine());

double distancia = kmFinal - kmInicial;
double resultado = distancia / litrosConsumidos;

Console.Write($"o consumo foi de: {resultado} litros");