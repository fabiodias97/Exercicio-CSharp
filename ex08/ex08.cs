using System;

namespace ex08
{
    class Exercicio08
    {
        static void Main()
        {
            // VAMOS REALIZAR EXERCÍCIO COM ARRAY / VETOR
            int[] num={77,88,99};

            char escolha;
            inicio:
            Console.Clear();

            Console.Write("Números na Posiçao 1 = 77 | Posição 2 = 88 | Posição 3 = 99\n");
            Console.Write("Informe número para alterar na posiçao 2: ");
            num[1] = int.Parse(Console.ReadLine());
            Console.Write("Posiçao 1 - tem o número {0}\n",num[0]);
            Console.Write("Posiçao 2 - tem o número {0}\n",num[1]);
            Console.Write("Posiçao 3 - tem o número {0}\n",num[2]);

            Console.Write("Quer Continuar? [S/N]: ");
            escolha = char.Parse(Console.ReadLine());
            if(escolha == 's' || escolha == 'S')
            {
                goto inicio;
                Console.Clear();
            }else
            {
                Console.Write("Fim do Programa! ");
            }
        } 
    }
}