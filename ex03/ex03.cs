using System;

namespace Ex03
{
    class ex03
    {
        static void Main(string[] args)
        {   
            // OPERAÇOES COM O BITWASE
            double num1 = 10<<1; // para Dobrar o valor utiliza-se o (" << ")
            Console.Write("O Número 10 foi DOBRADO 1 vez, e está com valor {0}\n", num1);


            double num2 = 10>>1; // para Dividir o valor utiliza-se 0 (" >> ")
            Console.Write("O Número 10 foi DIVIDIDO 1 vez, e está com valor {0}", num2);
        }
    }
}