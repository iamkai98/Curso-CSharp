namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {


            double nota1, nota2, media;


            Console.WriteLine("Digite sua primeira nota");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("A média é:{0}", media);
        }
    }
}
