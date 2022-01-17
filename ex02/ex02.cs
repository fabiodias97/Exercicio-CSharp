using System;

namespace ex02
{
    class exercicio02
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int resultado = 0;

            Console.Write("Insira o Primeiro Número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Insira o Segundo Número: ");
            num2 = int.Parse(Console.ReadLine());

            resultado = num1 + num2;
            Console.Write("O resultado da soma foi: " + resultado);
        }
    }
}