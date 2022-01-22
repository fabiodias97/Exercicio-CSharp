using System;

namespace ex07
{
    class Exercicio07
    {
        static void Main()
        {
            int numero=0;
            char escolha;

            inicio:
            Console.Clear();

            Console.Write("Informe uma Letra: [A] | [B] | [C]: ");
            escolha=char.Parse(Console.ReadLine());
            switch(escolha)
            {
                case 'A':
                    numero = 20;
                    Console.Write("O número vale {0}\n", numero);
                    break;
                case 'B':
                    numero=30;
                    Console.Write("O número vale {0}\n", numero);
                    break;
                case 'C':
                    numero=40;
                    Console.Write("O número vale {0}\n", numero);
                    break;
                default:
                    numero=50;
                    Console.Write("O número vale {0}\n", numero);
                    break;
            }
            Console.Write("Você deseja continuar? [S/N]: ");
            escolha=char.Parse(Console.ReadLine());
            if(escolha == 'S' || escolha == 's')
            {
                goto inicio;
                Console.Clear();
            }else
            {
                Console.Clear();
                Console.Write("Fim do Programa");
            }
        }
    }
}