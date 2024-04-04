using System;
class HelloWorld
{
    static void Main()
    {
        int entrada, quadrado, soma = 0, dividir;
        Console.WriteLine("Escreva um número inteiro");
        entrada = int.Parse(Console.ReadLine());

        quadrado = entrada * entrada;
        while (quadrado > 0)
        {
            dividir = quadrado % 10;
            soma = soma + dividir;
            quadrado /= 10;
        }
        Console.WriteLine("E a soma dos números de seu quadrado é " + soma);

    }
}