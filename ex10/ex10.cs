using System;

namespace ex10
{
    class Exercício10
    {
        static void Main()
        { //TRABALHANDO COM ESTRUTURA DE REPETIÇÃO "WHILE" E "DO WHILE" 
            
            ////////////// WHILE ///////////////////////////////////////
            int password= 123;
            int passUser;
            int num=0;
            while(num<10)
            {
                num+=1;
                Console.WriteLine("Olá " + num);
            }

            ////////////////// DO WHILE //////////////////////////////
            do{
                Console.Clear();
                Console.Write("Informe sua Senha: ");
                passUser = int.Parse(Console.ReadLine());
            }while(password != passUser);
                Console.WriteLine("Autorizado");

            Console.Write("Fim do Programa");
        }   

    }
}