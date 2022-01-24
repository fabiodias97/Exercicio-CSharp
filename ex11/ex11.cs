using System;

namespace ex11
{
    class Exercício11
    {
        static void Main()
        {   // Trabalhando com Métodos

            int valor1,valor2;
            Console.Write("Informe o Primeiro Valor: ");
            valor1=int.Parse(Console.ReadLine());  // AGUARDA O USUÁRIO INSERIR UM VALOR
            Console.Write("Informe o Segundo Valor: ");
            valor2=int.Parse(Console.ReadLine());
            calculo(valor1,valor2); // CHAMA O  MÉTODO "CALCULO"
        }
        static void calculo(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("O Resultado da soma entre {0} e {1} é igual a {2}", num1,num2,resultado);
        }
    }
}