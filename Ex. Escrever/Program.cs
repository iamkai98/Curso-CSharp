namespace Ex._Escrever
{
    internal class Program
    {
        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new string('-', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine(textoCentralizado);
            Console.WriteLine(linha);
        }
        
        static void Main(string[] args)
        {
            Escrever("Kaique Pereira da Conceição");
            Console.WriteLine();
            Escrever("Curso C#");
            Console.WriteLine();
            Escrever("olá");
            Console.WriteLine();
        }
    }
}
