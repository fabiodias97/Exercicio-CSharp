using System;

namespace ex16
{
    public class Jogador{
        public int energia;
        //bool estaVivo;
        public string nome;
        public Jogador(string n){      // MÉTODO CONSTRUTOR
            energia=100;
            //estaVivo=true;
            nome=n;
        }
        ~Jogador(){  // MÉTODO DESTRUTOR
            Console.WriteLine("O jogador {0} foi banido!!",nome);
        }
    }
    class Exercicio16{
        static void Main(){
            Jogador jogador = new Jogador("Fabio");
            Console.Write("O Nome do jogador é {0}",jogador.nome);
            Console.Write(" e sua energia está em {0}%",jogador.energia);
        }
    }
}