namespace ListaDeExercicios17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor1;
            double valor2;
            double valor3;

            Console.WriteLine("Digite o primeiro valor: ");
            valor1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            valor2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor: ");
            valor3 = Double.Parse(Console.ReadLine());

            double soma = valor1 + valor2;

            if (soma < valor3)
            {

                Console.WriteLine("A soma de A + B é menor que C");

            }
            else
            {
                Console.WriteLine("A soma de A + B é maior que C");
            }

            Console.ReadKey();
        }
    }
}
