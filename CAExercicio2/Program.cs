using System;

namespace CAExercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Construtor Padrão
            Vetor2D V1 = new Vetor2D();

            Console.WriteLine("Construtor padrão: ");
            Console.WriteLine("Vetor: " + V1.getX() + ", " + V1.getY() + ") \n");

            // Construtor com argumentos 
            Vetor2D V2 = new Vetor2D(2.0, 1.0);

            Console.WriteLine("Construtor com argumentos");
            Console.WriteLine("Vetor: (" + V2.getX() + ", " + V2.getY() + ") \n");

            // Lendo valores do console
            Console.Write("Entre com a coordenada X: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Entre com a coordenada Y: ");
            double y = double.Parse(Console.ReadLine());
            Vetor2D V3 = new Vetor2D(x, y);
            Console.WriteLine("\nVetor informado pelo usuario: (" + V3.getX() + ", " + V3.getY() + ") \n");


            // Apresentando modulo do vetor
            Console.WriteLine("Módulo de (" + V3.getX() + "," + V3.getY() + "): " + V3.modulo() + " \n");

            // Apresentando angulo do vetor
            Console.WriteLine("Angulo entre (" + V2.getX() + "," + V2.getY() + ") e (" + V3.getX() + "," + V3.getY() + "): " + V2.angulo(V3) + "°\n");

            // Apresentando produto escalar entre os vetores
            Console.WriteLine("Produto escalar entre (" + V2.getX() + "," + V2.getY() + ") e (" + V3.getX() + "," + V3.getY() + "): " + V2.produtoEscalar(V3) + "\n");


            Console.ReadLine();
        }
    }
}
