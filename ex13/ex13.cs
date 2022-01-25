using System;

namespace ex13
{
    class Exercício13
    {
        static void Main()
        {
            // EXERCÍCIO COM MATRIZES
            int[,] num= new int[4,4]{{10,20,30,40},{50,60,70,80},{100,110,120,130},{140,150,160,170}};

            Console.Write(num[2,2]); // resultado será 120
        }
    }
}