using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio19
{
    // Exercício 
    public class Principal
    {
        static void Main()
        {
            Carro c=new Carro("Civic" , "Preto");

            Console.WriteLine("Nome do Carro: {0} ", c.Nome);
            Console.WriteLine("Cor do Carro: {0}", c.Cor);
            Console.WriteLine("Carro está Ligado ? {0}", c.getLigado());
        }
    }
}