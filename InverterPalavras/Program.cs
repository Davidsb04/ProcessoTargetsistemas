namespace InverterPalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra, palavraAoContrario = "";

            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine().ToLower();

            char[] vetor = palavra.ToCharArray();


            for (int i = vetor.Length - 1; i >= 0; i--)
            {
                palavraAoContrario += vetor[i];
            }

            Console.WriteLine($"\nA palavra {palavra} ao contrário é: {palavraAoContrario}");
            Console.ReadKey();
        }
    }
}
