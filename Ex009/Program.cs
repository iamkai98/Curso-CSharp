namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.WriteLine("Programa para testar triângulos:");


            Console.WriteLine("Digite o valor do Lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do Lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do Lado C: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoC))
            {
                Console.WriteLine("Os valores informados formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Os valores informados não formam um triângulo");
            }
        }
    }
}
