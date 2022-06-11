using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aulaa03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            Console.WriteLine("Digigte 5 valores");            
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            int soma = 0;  
            for (int j = 0; j < valores.Length; j++)
            {
                soma += valores[j];
            }
            Console.WriteLine(soma);
            Console.ReadLine();
        }
    }
}
