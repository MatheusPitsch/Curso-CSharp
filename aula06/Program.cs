using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cachorro[] cachorrada = new Cachorro[3];

            /* for (int i = 0; i <  cachorrada.Length; i++)
             {
                 Cachorro cao = new Cachorro();

                 Console.WriteLine($"Nome do cachorro:");
                 cao.nameDog = Console.ReadLine();

                 Console.WriteLine("\nNome do dono:");
                 cao.nameMaster = Console.ReadLine();

                 Console.WriteLine("\nIdade do cachorro:");
                 cao.ageDog = Convert.ToInt32(Console.ReadLine());

                 cachorrada[i] = cao;

                 Console.Clear();
             }            */

            /* for (int i = 0; i < cachorrada.Length; i++)
             {               
                 Console.WriteLine($"Nome do cachorro:");
                 String nameDog = Console.ReadLine();

                 Console.WriteLine("\nNome do dono:");
                 String nameMaster = Console.ReadLine();

                 Console.WriteLine("\nIdade do cachorro:");
                 int ageDog = Convert.ToInt32(Console.ReadLine());

                 Cachorro cao = new Cachorro(nameDog,nameMaster,ageDog);

                 Console.Clear();
             }*/
           
            for (int i = 0; i < cachorrada.Length; i++)
            {
                Cachorro cao = new Cachorro();

                Console.WriteLine($"Nome do cachorro:");
                cao.setNameDog(Console.ReadLine());

                Console.WriteLine("\nNome do dono:");
                cao.setNameMaster(Console.ReadLine());

                Console.WriteLine("\nIdade do cachorro:");
                int ageDog = Convert.ToInt32(Console.ReadLine());

                

                Console.Clear();
            }


            for (int i = 0; i < cachorrada.Length; i++)
            {
                if (cachorrada[i].ageDog >= 6)
                {
                    Console.WriteLine($"\nNome: {cachorrada[i].getNameDog()},\n Idade: {cachorrada[i].ageDog},\n Dono: {cachorrada[i].getNameMaster()}");
                }

            }



            Console.ReadLine();
        }
    }
}
