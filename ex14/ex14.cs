using System;

namespace ex14
{
    class Exercício
    {
        static void Main()
        {
            int[] vetor1 = new int[5];

            Random random = new Random();
            for (int i = 0; i < vetor1.length; i++)
            {
                vetor1[i] = random.Next(10);
            }

            Console.write("Elementos do Vetor 1")
            foreach (int n in vetor1)
            {
                Console.write(n);
            }
        }
    }
}