namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Kaique");
            Soma(10,20);
        }

        static void Saudacao (string nome)
        {
            Console.WriteLine($"Olá, {nome}! Seja bem vindo");
        }

        static void Soma(int a , int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A some de {a} + {b} é igual a {resultado}");
        }
        

    }
}
