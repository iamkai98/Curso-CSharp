namespace Calcule_a_área_do_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========");
            Console.WriteLine("Calcule a área do triangulo");
            Console.WriteLine("=========");
            Console.WriteLine();

            Console.WriteLine("Digite a medida da base:");
            double medidaBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Digite a medida da altura:");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            AreaTerreno(medidaBase, altura);
        }
        static void AreaTerreno(double b, double c)
        {
        double a = b * c;
            Console.WriteLine($"A área do triângulo é de {b}m x {c}m é de {a:F2}m²");
        }
    }
}
