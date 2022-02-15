using System;

namespace Exercicio18
{
    class Calculo
    {
        public int v1;
        public int v2;

        public Calculo(int v1, int v2)
        {
            this.v1=v1;
            this.v2=v2;
        }
        public int Soma()
        {
            return v1 + v2;
        }
    }
    class Ex18
    {
        static void Main()
        {
            Calculo c = new Calculo(12,2);

            Console.WriteLine(c.Soma());
        }
    }
}