using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio19
{
    public class Veiculo  // Classe Base
    {
        public int Rodas;
        private bool Ligado;
        public int VelMax;

        public void Ligar() // CONSTRUTOR
        {
            Ligado=true;
        }
        public void Desligar() // CONSTRUTOR
        {
            Ligado=false;
        }
        public string getLigado() // MÉTODO
        {
            if(Ligado){
                return "Sim";
            }else{
                return "Não";
            }
        }
    }
}