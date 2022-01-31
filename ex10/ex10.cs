using System;

namespace ex10
{
    class Exercício10
    {
        static void Main()
        { //TRABALHANDO COM ESTRUTURA DE REPETIÇÃO "WHILE" E "DO WHILE" 
            
            ////////////// WHILE ///////////////////////////////////////
            string password= "123";
            string passUser="999";
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
                passUser = Console.ReadLine();
            }while(password != passUser);
                Console.WriteLine("Autorizado");

            Console.Write("Fim do Programa");
        }   

    }
}