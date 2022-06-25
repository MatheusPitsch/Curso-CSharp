using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex01
            {
                //Pessoa p1 = new Pessoa();

                //Console.WriteLine("Digite o Nome:");
                //p1.nome = Console.ReadLine();
                //Console.WriteLine("Digite a Idade");
                //p1.idade = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("CPF:");
                //p1.cpf = Console.ReadLine();
                //Console.WriteLine("Endereço:");
                //p1.endereco = Console.ReadLine();

                //Console.WriteLine($"Nome: {p1.nome}, Idade: {p1.idade}, cpf: {p1.cpf}, endereço: {p1.endereco}");
            }

            //Ex02
            {
                //Pet[] cachorro = new Pet[2];
                //for (int i = 0; i < cachorro.Length; i++)
                //{
                //    Console.WriteLine("Digite o nome do dono:");
                //    cachorro[i].nomeDono = Console.ReadLine();
                //    Console.WriteLine("Digite o nome do cachorro:");
                //    cachorro[i].nomeDog = Console.ReadLine();
                //    Console.WriteLine("Digite a idade do cachorro:");
                //    cachorro[i].idadeCachorro = Convert.ToInt32(Console.ReadLine());
                //    Console.Clear();
                //}


                //for (int i = 0; i < cachorro.Length; i++)
                //{
                //    if (cachorro[i].idadeCachorro > 6)
                //    {
                //        Console.WriteLine($"O nome do dono é: {cachorro[i].nomeDono},\n o nome do pet é: {cachorro[i].nomeDog},\n e a idade do cachorro é: {cachorro[i].idadeCachorro}");
                //    }
                    
                //}

            }

            //Ex03
            {
                //Aluno[] sala1 = new Aluno[2];
                //for (int i = 0; i < sala1.Length; i++)
                //{
                //    Console.WriteLine("Nome:");
                //    sala1[i].nome = Console.ReadLine();
                //    Console.WriteLine("Nota1:");
                //    sala1[i].nota1 = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Nota2:");
                //    sala1[i].nota2 = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Nota3:");
                //    sala1[i].nota3 = Convert.ToDouble(Console.ReadLine());

                //    sala1[i].media = ((sala1[i].nota1 + sala1[i].nota2 + sala1[i].nota3) / 3);
                //}
                
                //Console.Clear();

                //for (int i = 0; i < sala1.Length; i++)
                //{
                //    if (sala1[i].media >= 7)
                //    {
                //        Console.WriteLine($"O aluno {sala1[i].nome},\n está aprovado,\n a média do aluno é: {sala1[i].media}.");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"O aluno {sala1[i].nome},\n está reprovado,\n a média do aluno é: {sala1[i].media}.");
                //    }
                //    Console.WriteLine();
                //}

            }


            Console.ReadLine();

        }

        public struct Pessoa
        {
            public string nome;
            public int idade;
            public string cpf;
            public string endereco;
        }

        public struct Pet
        {
            public string nomeDono, nomeDog;
            public int idadeCachorro;

        }

        public struct Aluno
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double nota3;
            public double media;

        }

        
    }
}
