using System;

namespace Ex17
{
    class Aluno
    {
        static public bool alerta;
        public string nome;
        public Aluno(string n){  // Construtor Aluno 
            alerta=false;
            nome=n;
        }
        public void info(){  // Método info
            Console.Write(nome);
            Console.WriteLine(alerta);
        }
    }
    class Ex17
    {
        static void Main(){  // Método Principal
            Aluno a1=new Aluno("Fabio "); // Instânciando a Class Aluno
            Aluno a2=new Aluno("João ");
            Aluno a3=new Aluno("Mike ");

            Aluno.alerta=true;

            a1.info();
            a2.info();
            a3.info();
        }
    }
}