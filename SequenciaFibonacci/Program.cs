namespace SequenciaFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0, a = 0, b = 1, limite = 17;
            bool contemNumero = false;

            Console.Write("\nInforme o número que deseja pesquisar (até 2584): ");
            int numPesquisa = int.Parse(Console.ReadLine());

            while (cont < limite)
            {
                int n = a;
                a = b;
                b = n + b;
                if (numPesquisa == b)
                {
                    contemNumero = true;
                }
                cont++;
                Console.WriteLine(b);
            }

            if (contemNumero)
            {
                Console.WriteLine("\nA sequência de Fibonacci contém o número que você informou.");
            }
            else
            {
                Console.WriteLine("\nA sequência de Fibonacci não contém o número que você informou.");
            }
            Console.ReadKey();
        }
    }
}
