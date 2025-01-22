namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float dinheiro, valorTotal;
            Console.WriteLine("Escreva o seu salário:");
            dinheiro = Convert.ToInt32(Console.ReadLine());

            if (dinheiro > 2500)
            {
                valorTotal = dinheiro + (dinheiro * 0.05f);
                Console.WriteLine("Valor total = {0}", valorTotal);
            }

            else if (dinheiro > 1250)
            {
                valorTotal = dinheiro + (dinheiro * 0.10f);
                Console.WriteLine("Valor Total = {0}", valorTotal);
            }

            else
            {
                valorTotal = dinheiro + (dinheiro * 0.15f);
                Console.WriteLine("Valor total = {0}", valorTotal);
            }
                



            
        }
    }
}
