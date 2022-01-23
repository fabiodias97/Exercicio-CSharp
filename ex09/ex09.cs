using System;

namespace ex09
{
    class Exercício09
    {
        static void Main()
        { // TRABALHANDO COMESTRUTURA DE REPETIÇÃO "FOR" E "FOREACH"
            ///////////////////// FOR ////////////////////////////
            int[] num={11,22,33};
            for(int i=1;i<=10;i++)
            {
                Console.Write(i); // Irá realizar uma contagem de 0 até 9
            }
            //////////////////// FOREACH ///////////////////////////
            foreach(int n in num)
            {
                Console.Write("\t"+ n);
            }
        }
    }
}