using System;

namespace Ex17
{
    class Aluno
    {
        static public bool alerta;
        public string nome;
        public Aluno(string n){
            alerta=false;
            nome=n;
        }
        public void info(){
            Console.Write(nome);
            Console.WriteLine(alerta);
        }
    }
    class Ex17
    {
        static void Main(){
            Aluno a1=new Aluno("Fabio ");
            Aluno a2=new Aluno("João ");
            Aluno a3=new Aluno("Mike ");

            Aluno.alerta=true;

            a1.info();
            a2.info();
            a3.info();
        }
    }
}