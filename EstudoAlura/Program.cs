using System;

namespace EstudoAlura
{
    class Program
    {
        static void Main(string[] args)
        {

            GeradorFuncionario();


        }

        public static void GeradorFuncionario()
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Desenvolvedor paulo = new Desenvolvedor();
            paulo.nome = "paulo";

            gerenciador.somaBonificacao(paulo);
            Console.WriteLine(Funcionario.totalFuncionario);


            Diretor vitor = new Diretor();
            vitor.nome = "vitor";

            gerenciador.somaBonificacao(vitor);
            Console.WriteLine(Funcionario.totalFuncionario);

            Console.WriteLine("Nome: " + paulo.nome);
            Console.WriteLine("Salario: " + paulo.Salario);
            Console.WriteLine("Bonificao: " + paulo.GetBonificao());
            paulo.AumentoSalario();
            Console.WriteLine("Aumento de salario: " + paulo.Salario);


            Console.WriteLine("Nome: " + vitor.nome);
            Console.WriteLine("Salario: " + vitor.Salario);
            Console.WriteLine("Bonificao: " + vitor.GetBonificao());
            vitor.AumentoSalario();
            Console.WriteLine("Aumento de salario: " + vitor.Salario);


            Console.WriteLine("Total de bonificao: " + gerenciador.GetTotalBonificao());

        }


    }
}
