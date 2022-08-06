using System;
using System.Collections.Generic;


namespace aula07
{
    internal class Program
    {
        private static int QUANTIDADEDEPERGUNTAS = 2;

        static void Main(string[] args)
        {

            {/*
                List<string> valores = new List<string>();
                
                Console.WriteLine("Olá, sou sua assistente virtual Meusa de psicologia remota a distancia de lonjao, quais são suas aflições?");

                for (int i = 0; i < QUANTIDADEDEPERGUNTAS; i++)
                {
                    valores.Add(Console.ReadLine());

                }

                foreach (var item in valores)
                {
                    Console.WriteLine(item);
                }

                */

            }

            {
                /*
                List<double> notas = new List<double>();

                Console.WriteLine("Digite a nota do aluno");

                for (int i = 0; i < 3; i++)
                {
                    notas.Add(Convert.ToDouble(Console.ReadLine()));

                }

                Console.WriteLine("A média do aluno foi:");
                double notafinal = 0;
                foreach (var item in notas)
                {
                    notafinal += item / notas.Count;
                }

                Console.WriteLine(notafinal);


*/
            }


            {/*
                bool saoiguais = true;

                List<double> valores = new List<double>();

                Console.WriteLine("Insira 3 valores");

                for (int i = 0; i < 3; i++)
                {
                    valores.Add(Convert.ToDouble(Console.ReadLine()));

                }

                valores.Sort();

                for (int i = 0; i < valores.Count - 1; i++)
                {
                    if (valores[i] != valores[i + 1])
                    {
                        saoiguais = false;
                        break;
                    }
                }

                if (saoiguais)
                {
                    Console.WriteLine("São iguais");
                }
                else
                {
                    Console.WriteLine($"O maior é: {valores[valores.Count - 1]}");
                }
                */
            }

            {/*
                List<double> list = new List<double>();

                while (true)
                {
                    double entradaUser = 0;

                    Console.WriteLine("Insira um número");
                    Console.WriteLine("ou 0 para sair");

                    entradaUser = Convert.ToDouble(Console.ReadLine());
                    if (entradaUser == 0)
                    {
                        break;
                    }
                    else
                    {
                        list.Add(entradaUser);
                        Console.Clear();
                    }

                    double resultado = 1;

                    //Para listas é usado o count e para arey é usado length;?
                    for (int i = 0; i < list.Count; i++)
                    {
                        resultado *= list[i]; 
                    }
                    Console.WriteLine("O resultado foi:");
                    Console.WriteLine(resultado);
                
                }
                */
            }

            {
                List<User> usuarios = new List<User>();
                usuarios.Add(new User("Admin", "Proway"));

                while (true)
                {
                    Console.WriteLine("Insira o Login");
                    Console.WriteLine("Insira Sair para finalizar");
                    string login = Console.ReadLine();
                    if (login.ToLower() == "sair")
                    {
                        Console.WriteLine("Gracias");
                    }
                    Console.WriteLine("Qual a senha?");
                    string senha = Console.ReadLine();


                    bool deuErrado = true, admin = false;
                    foreach (var item in usuarios)
                    {
                        if (item.Login == login)
                        {
                            if (item.Senha == senha)
                            {
                                deuErrado = false;
                                if (item.Login == "Admin")
                                {
                                    admin = true;
                                }

                            }
                        }
                    }


                    if (deuErrado)
                    {
                        Console.WriteLine("Errou alguma coisa");
                    }

                    if (admin)
                    {
                        while (true)
                        {
                            Console.WriteLine("Seja bem vindo adm");
                            Console.WriteLine("MENU");
                            Console.WriteLine("1- Criar Conta");
                            Console.WriteLine("2- Deletar Conta");
                            Console.WriteLine("3- LogOut");

                            int escolha = Convert.ToInt32(Console.ReadLine());

                            if (escolha == 1)
                            {
                                Console.WriteLine("Insira o Login ");
                                string cadatroNome =  Console.ReadLine();
                                foreach (var item in usuarios)
                                {
                                    if (item.Login == cadatroNome)
                                    {
                                        break;
                                    }
                                }

                            }
                            else if (escolha == 2)
                            {

                            }
                            else if( escolha == 3)
                            {
                                Console.WriteLine("LogOut Realizado");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opção invalida");
                            }


                        }
                    }

                    Console.WriteLine("Para proseguir aperte enter");
                    Console.ReadLine();
                    Console.Clear();









                }


            }


            Console.ReadLine();

        }
    }
}
