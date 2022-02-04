using System;

namespace ex14
{
    class Exercício
    {
        static void Main()
        {
            int num1,num2,men,s;
            num1=10;
            num2=30;
            men = dobrar(num1, num2, out s);
            Console.Write(men + "", s);
        }
        static int dobrar(int valor1, int valor2, out int som){
            int sub;
            sub = valor1 - valor2;
            som = valor1 + valor2;
            return sub;
            return som;
            
        }
    }
}