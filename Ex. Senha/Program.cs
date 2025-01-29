namespace Ex._Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123"; //Senha digitada
            string senhaDigitada; // Senha digitada pelo usuário 
            int tentativas = 0;

            // Verificar se a senha está correta 
            do
            {
                Console.Clear();
                Console.WriteLine("Digite a senha:");
                senhaDigitada = Console.ReadLine();
                tentativas++;

                if (senhaDigitada != senha && tentativas > 3)
                {
                    Console.WriteLine("Senha incorreta");
                    Console.WriteLine("Você ainda tem " + (3 - tentativas) + " tentativa(s)");
                    Console.ReadKey();
                }
                else if (senhaDigitada != senha && tentativas == 3)
                {
                    Console.WriteLine("Senha incorreta! Seu acesso está bloquedo!");
                    return;
                }
            } while (senhaDigitada != senha);

            Console.Clear();
            Console.WriteLine("Senha correta");
        }
    }
}
