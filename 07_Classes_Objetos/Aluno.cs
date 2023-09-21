//O namespace é um nome que usaremos para fazer referência quando usarmos
using System.Reflection.PortableExecutable;

namespace Sesi.Model
{
    //Declarando a classe Aluno
    public class Aluno 
    {
        //Declarando os atributos (propriedades) de classe aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }

        //Declarando um atributo privado
        public int nrFaltas { get; set; }

        //Criando um método
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anos e estudo na turma {turma} e tenho {nrFaltas} faltas ");
        }

        public void AdicionarFaltas(int nr)
        {
            Console.WriteLine($"A aluna {nome} faltou hoje e somou {nrFaltas}");
            nrFaltas = nrFaltas + nr;
        }

        public void ResumoFaltas()//parâmetro
        {
            Console.WriteLine($"A aluna {nome} tem {nrFaltas} faltas ");
        }
    }
}