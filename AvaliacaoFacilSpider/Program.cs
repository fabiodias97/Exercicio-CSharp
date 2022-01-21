using System;

namespace AvalicaoProgramacao
{
	class Program
	{
		static void Main(string[] args)
		{
			int valor1 = 0;
			int valor2 = 0;
			string operacao = "";
			bool usuarioInformouValorValido;
			usuarioInformouValorValido = false;
			while (!usuarioInformouValorValido)
			{
				try
				{
					Console.Write("Digite o valor do primeiro número: ");
					valor1 = int.Parse(Console.ReadLine());
					usuarioInformouValorValido = true;

                    Console.Write("Digite o valor do segundo número: ");
					valor2 = int.Parse(Console.ReadLine());
					usuarioInformouValorValido = true;
				}
				catch
				{
					Console.WriteLine("O número informado não é válido. Você deve digitar um número inteiro.");
				}
			}
			usuarioInformouValorValido = false;
			while (!usuarioInformouValorValido)
			{
				Console.Write("Digite a operação entre os números, utilizando os caracteres '+', '-', '/' ou '*': ");
				operacao = Console.ReadLine();
				if ((operacao == "+") || (operacao == "-") || (operacao == "/") || (operacao == "*"))
				{
					usuarioInformouValorValido = true;
				}
				else
				{
					Console.WriteLine("A operação informada não é válida.");
					Console.WriteLine("Para operação de soma, informe o caractere '+'.");
					Console.WriteLine("Para subtrair o segundo número do primeiro, informe o caractere '-'.");
					Console.WriteLine("Para operação de multiplicação, informe o caractere '*'.");
					Console.WriteLine("Para dividir o primeiro número pelo segundo, informe o caractere '/'.");
				}
			}
			double resultado = calcular(valor1, valor2, operacao);
			Console.WriteLine("Resultado: " + resultado.ToString());
			Console.ReadKey();
		}
		static double calcular(int numero1, int numero2, string operacaoASerRealizada)
		{
			//local onde o código da sua resposta deve ser inserido para fazer o programa funcionar
           
		}
    }
}