using System;

namespace CAExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno("Leticia", "12011EEL028", "92915341");
            Aluno aluno2 = new Aluno("", "", "");

            // Mostrando valores iniciados pelo usuário
            Console.WriteLine("\nContrutor com valores iniciados pelo usuário: \n ");
            Console.WriteLine("Nome do Aluno: " + aluno1.getNome());
            Console.WriteLine("Matrícula do Aluno: " + aluno1.getMatricula());
            Console.WriteLine("Telefone do Aluno: " + aluno1.getTelefone());

            // Lendo valores do usuário
            Console.WriteLine("\n\nInforme o nome do aluno: ");
            aluno2.setNome(Console.ReadLine()); ;
            Console.WriteLine("Informe a matrícula do aluno: ");
            aluno2.setMatricula(Console.ReadLine());
            Console.WriteLine("Informe o telefone do aluno: ");
            aluno2.setTelefone(Console.ReadLine());


            Console.WriteLine("\nDados do aluno informados pelo usuário \n");
            Console.WriteLine("Nome: " + aluno2.getNome());
            Console.WriteLine("Matrícula: " + aluno2.getMatricula());
            Console.WriteLine("Telefone: " + aluno2.getTelefone());

            Console.ReadLine();
        }
    }
}
