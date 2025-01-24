namespace Ex_Estrutura_de_repetição_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string genero;
            Console.WriteLine("Digite seu genero:");
            genero = Console.ReadLine().ToUpper();
            
            while (genero != "F" && genero != "M")
                {
                Console.WriteLine("Digite o gênero: ");
                genero = Console.ReadLine();
            }

            Console.WriteLine("Bem vindos e bem vindas ao curso C#!");
        }
    }
}
