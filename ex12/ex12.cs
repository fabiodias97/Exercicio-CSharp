using System;
 
 namespace ex12
 {
     class Exercício12
     {
         static void Main()
         {
             int num=10;
             dobrar(ref num); // PASSAGEM DE VALOR POR REFERÊNCIA
             Console.Write(num);

         }
         static void dobrar(ref int valor)
         {
            valor*=2;
         }
     }
 }