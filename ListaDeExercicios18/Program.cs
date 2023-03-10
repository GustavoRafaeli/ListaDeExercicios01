namespace ListaDeExercicios18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1;
            int valor2;
            int valor3;
            int aux = 0;

            Console.WriteLine("Escreva o primeiro valor: ");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o segundo valor: ");
            valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escreva o terceiro valor: ");
            valor3 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                aux = valor1;
                valor1 = valor2;
                valor2 = aux;
            }

            if (valor1 > valor3)
            {
                aux = valor1;
                valor1 = valor3;
                valor3 = aux;
            }

            if (valor2 > valor3)
            {
                aux = valor2;
                valor2 = valor3;
                valor3 = aux;
            }
            Console.WriteLine("Valores ordenados: " + valor1 + ", " + valor2 + ", " + valor3);

            Console.ReadKey();
        }
    }
}