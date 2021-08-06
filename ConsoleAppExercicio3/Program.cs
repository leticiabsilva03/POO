using System;

namespace ConsoleAppExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempo h1 = new Tempo();
            Tempo h2 = new Tempo(14, 35, 43);
            Tempo h3 = new Tempo(0, 0, 0);

            // Iniciando com valores vazios
            Console.WriteLine("Contrutor Padrão Vazio: \n "); 
            Console.WriteLine("Horas: " + h2.t_hora + ":" + h2.t_min + ":" + h2.t_segs);
           

            // Lendo valores do usuário
            Console.WriteLine("\n\nInforme a hora: ");
            h3.setHora(int.Parse(Console.ReadLine())); // parse converte string representation of a number to its 32-bit signed integer equivalent
            Console.WriteLine("Informe os minutos: ");
            h3.setMinutos(int.Parse(Console.ReadLine()));
            Console.WriteLine("Informe os segundos: ");
            h3.setSegundos(int.Parse(Console.ReadLine()));

            Console.WriteLine("\nHora informada pelo usuário: " + h3.getHora() + ":" + h3.getMinutos() + ":" + h3.getSegundos());
            Console.ReadLine();
        }
    }
}
