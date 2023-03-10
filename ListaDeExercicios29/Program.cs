namespace ListaDeExercicios29
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 10; i++) //multiplicador
            {
                for (int j = 1; j <= 10; j++) //multiplicando
                {
                    Console.Write("{0,3} x {1,-2} = {2,-3}", i, j, i * j);
                }
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}