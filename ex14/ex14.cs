using System;

namespace ex14
{
    class Exercício
    {
        static void Main()
        {
            int num1,num2,adic,subt;
            num1=10;
            num2=30;
            adic=Math(num1, num2, out subt);
            Console.Write("{0} Adição e {1} Subtração ", subt, adic);
        }
        static int Math(int valor1, int valor2, out int som){
            int sub;
            sub=valor1-valor2;
            som=valor1+valor2;
            return sub;
        }
    }
}