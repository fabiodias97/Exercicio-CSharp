using System;

namespace ex05
{
    class Exercicio05
    {
        static void Main(string[] args)
        {
            float media, nota1, nota2, nota3, nota4;
            media=nota1=nota2=nota3=nota4=0;
            string nome;
        
            Console.Write("Qual é o seu nome?  ");
            nome = Console.ReadLine();
            Console.Write("Informe qual foi sua Nota do Primeiro Trimestre: ");
            nota1 = float.Parse(Console.ReadLine());

            Console.Write("Informe qual foi sua Nota do Segundo Trimestre: ");
            nota2 = float.Parse(Console.ReadLine());

            Console.Write("Informe qual foi sua Nota do Terceiro Trimestre: ");
            nota3 = float.Parse(Console.ReadLine());

            Console.Write("Informe qual foi sua Nota do Quarto Trimestre: ");
            nota4 = float.Parse(Console.ReadLine());

            media = (nota1+nota2+nota3+nota4)/4;

            Console.Write(nome +" a sua Média Geral foi de: " + media);
        }
    }
}