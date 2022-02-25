using System;

namespace Estudo
{
    public class Energia
    {
       public string energiza;
    }
    public class TesteLampada : Energia
    {
        static bool valorAtual;
        static void Main(string[] args)
        {
            Energia conta = new Energia();



            conta.energiza = "André";

            Aluno atributos = new Aluno();
            Aluno Andre = new Aluno();
            Aluno Antonio = new Aluno();
            Program lampada = new Program();
            //valorAtual = lampada.verEstadoLampada();
            //Console.WriteLine(valorAtual);
            lampada.AcenderLampada();
            Console.WriteLine(lampada.verEstadoLampada());
            lampada.ApagarLampada();
            Console.WriteLine(lampada.verEstadoLampada());
            atributos.idade = 20;
            atributos.nota = 10;
            Console.WriteLine("Nota " + atributos.nota);
            Antonio.idade = 21;
            Antonio.nota = 10;
            Antonio.aprovado = true;

            Andre.idade = 24;
            Andre.nota = 4;
            Andre.aprovado = false;

            Console.WriteLine(Antonio.idade +" "+ Antonio.aprovado + " " + Andre.idade + " " + Andre.aprovado);
        }
    }

    class Program
    {
        public bool estadoLampada = false;
        public void AcenderLampada()
        {
            estadoLampada = true;
        }
        public void ApagarLampada()
        {
            estadoLampada = false;
        }
        public bool verEstadoLampada()
        {
            return estadoLampada;
        }
        public void getMatriz()
        {

        }
    }
    class Aluno
    {
       public string nome;
       public int idade, nota, ano;
        public bool aprovado;
    }
}
