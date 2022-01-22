using System;

namespace ex06
{
    class Exercicio06
    {
        static void Main()
        {   // Estamos Fazendo Exercício com os Comando "SWITCH" e com "GOTO"
            int tempo=0;
            char escolha;

            inicio:
            Console.Clear();

            Console.Write("De Belo Horizonte/MG até Vitória/ES");
            Console.Write("Com qual Transporte você iria: [A]Avião | [C]Carro | [O]Ônibus ");
            escolha = char.Parse(Console.ReadLine());

            switch(escolha){
                case 'A' : 
                    tempo=50;
                    break;
                case 'C':
                    tempo=440;
                    break;
                case 'O':
                    tempo=660;
                    break;
                default:
                    tempo= -1;
                    break;
            }
            if(tempo < 0)
            {
                Console.WriteLine("Tansporte Indiponível!");
                Console.Write("Por vafor escolha um tipo de transporte");
            }else
            {
                Console.Write("Você levará {0} minutos para chegar ao destino", tempo);
            }

            Console.Write("\nVocê deseja Calcular outro transpote? [S/N]: ");
            escolha = char.Parse(Console.ReadLine());
            if(escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }else
            {
                Console.Clear();
                Console.Write("Fim do Programa");
            }
        }
    }
}