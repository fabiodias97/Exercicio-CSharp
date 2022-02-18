using System;

namespace Exercicio19
{ 
    class Carro: Veiculo // HERANÇA 
    {
        public string Nome;
        public string Cor;
        public Carro(string nome, string cor) // CONSTRUTOR COM PARÂMETROS DE ENTRADA
        {
            Desligar();
            Nome=nome;
            Cor=cor;
            Rodas=4;
            VelMax=180;
        }
    }
}
