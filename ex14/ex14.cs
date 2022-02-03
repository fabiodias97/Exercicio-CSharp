using System;

namespace ex14
{
    class Exercício
    {
        static void Main()
        {
            int res, men;
            int num1 = 10;
            int num2 = 30;
            men = dobrar(num1, num2, out res);
            Console.Write(men, res);
        }
        static void dobrar(int valor1, int valor2, out int resultado){
            int sub, reslt;
            sub = valor1 - valor2;
            result = valor1 + valor2;
            return sub;
            return reslt;
        }
    }
}