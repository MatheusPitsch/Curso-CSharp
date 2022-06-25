using System;

namespace aula05Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int valor1, valor2;
            Console.WriteLine("Digite dois valores");
            valor1 = Convert.ToInt32(Console.ReadLine());
            valor2 = Convert.ToInt32(Console.ReadLine());
            int resultado = Metodos.Compara(valor1, valor2);
            Console.Clear();
            Console.WriteLine(resultado);





            Console.ReadLine();

        }
    }
}
