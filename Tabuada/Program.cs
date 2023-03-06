internal class Program
{
    private static void Main(string[] args)
    {
        int count, factor;

        while (true)
        {
            Console.WriteLine("Digite um número inteiro de 1 a 9:");
            factor = int.Parse(Console.ReadLine());
            if (factor > 0 && factor < 10)
                break;
            Console.WriteLine("Número inválido");
        }

        if( factor > 0 && factor < 10)
        {
            for( count = 0; count < 11; count++)
            {
                Console.WriteLine(factor + " x " + count + " = " + factor * count);
            }
        }
        else
            Console.WriteLine("Número inválido");
    }
}