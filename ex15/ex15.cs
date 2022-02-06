using System;

namespace ex15
{
    class Exercicio15
    {
        static void Main(){
            Soma(10,2);
        }
        static void Soma(params int[]n){
            int res=0;
            if(n.Length < 1){
                Console.WriteLine("Nao existem valores a serem Somados");
            }else if(n.Length < 2){
                Console.WriteLine("Valores insuficientes para Soma: {0}",n[0]);
            }else{
                for(int i=0; i < n.Length; i++){
                    res+=n[i];
                }
                Console.Write("A soma dos Valores é: {0}", res);
            }
        }
    }
}
