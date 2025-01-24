namespace Ex_Tabuada_com_o_laço_FOR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero; // variavel do multiplicador 
        
            Console.WriteLine("Digite um número: "); // solicitando para que o usuário coloque um número 
            numero = Convert.ToInt32(Console.ReadLine()); // conversão do número informado de string para um número inteiro 
            

            for (int i = 1; i <= 10; i++) // comando for para repetição, contagem será de 1 em 1 e de 1 até 10 
            {
                int resultado = numero * i; // criação da varíavel resultado do multiplicando pelo multiplicador 
                Console.WriteLine("{0} x {1} = {2}", numero, i, resultado); // aparecer a mensagem com o multiplicando, multiplicador e o resultado 
            }
            
                
            
        }
    }
}
