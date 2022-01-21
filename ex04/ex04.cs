using System;

namespace Ex04
{
    class ex04
    {
        enum diaSemana
            {
                Domingo=1, Segunda, Terça, Quarta, Quinta, Sexta, Sábado
            }
        static void Main()
        {
            // Esercício com ENUMERADORES (enum)
            diaSemana ds = (diaSemana)2;
            Console.Write("Ahh então o seu Dia Preferido é {0}", ds);
        }
    }
}