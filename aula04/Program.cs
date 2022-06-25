using System;

namespace aula04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Leia uma matriz 4 x 4, conte e escreva quantos valores maiores que 10 ela possui.
            
            2) Declare uma matriz 5 x 5. Preencha com 1 a diagonal principal e com 0 os demais
            elementos. Escreva ao final a matriz obtida
           
            3) Faça um programa que preenche uma matriz 4 x 4 com o produto do valor da linha e da
            coluna de cada elemento. Em seguida, imprima na tela a matriz.
           
            4 ) Leia uma matriz 5 x 5. Leia também um valor X. O programa devera fazer uma busca  ́
            desse valor na matriz e, ao final, escrever a localizac ̧ao (linha e coluna) ou uma
            mensagem de “nao encontrado”.
            
            5) Leia duas matrizes 4 x 4 e escreva uma terceira com os maiores valores de cada posição
            das matrizes lidas.
            
            6)Gerar e imprimir uma matriz de tamanho 10 x 10, onde seus elementos sao da forma:
            A[i][j] = 2*i + 7*j − 2 se i < j;
            A[i][j] = 3*i − 1 se i = j;
            A[i][j] = 4*i − 5*j + 1 se i > j;
            
            7) Leia uma matriz de 3 x 3 elementos. Calcule a soma dos elementos que estão acima da
            diagonal principal.
           
            8) Leia uma matriz de 3 x 3 elementos. Calcule a soma dos elementos que estão abaixo da
            diagonal principal.
           
            9) Gere matriz 4 x 4 com valores no intervalo [1, 20]. Escreva um programa que
            transforme a matriz gerada numa matriz triangular inferior, ou seja, atribuindo zero a todos
            os elementos acima da diagonal principal. Imprima a matriz original e a matriz
            transformada.
           
            DESAFIO:
          
            10) Faça um programa para gerar automaticamente numeros entre 0 e 99 de uma cartela de
            bingo. Sabendo que cada cartela devera conter 5 linhas de 5 números, gere estes dados de
            modo a nao ter números repetidos dentro das cartelas. O programa deve exibir na tela a
            cartela gerada.*/
            //---------------
            //Ex01

            {
                //int[][] armazenaNumeros = new int[4][];
                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    armazenaNumeros[i] = new int[4];
                //}

                //int numAleatorio;
                //int maiorDez = 0;

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    for (int j = 0; j < armazenaNumeros[i].Length; j++)
                //    {
                //        Console.WriteLine($"Digite um número para a linha {i} na coluna {j}.");
                //        numAleatorio = Convert.ToInt32(Console.ReadLine());
                //        armazenaNumeros[i][j] = numAleatorio;
                //        if (numAleatorio > 10)
                //        {
                //            maiorDez++;
                //        }
                //    }
                //}

                //Console.WriteLine($"São maior que 10 {maiorDez} números.");
            }

            //---------------
            //Ex02

            {
                //int[][] armazenaNumeros = new int[5][];

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    armazenaNumeros[i] = new int[5];
                //}

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    for (int j = 0; j < armazenaNumeros[i].Length; j++)
                //    {
                //        if (i == j)
                //        {
                //            armazenaNumeros[i][j] = 1;
                //        }
                //    }
                //}

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    Console.WriteLine();
                //    for (int j = 0; j < armazenaNumeros[i].Length; j++)
                //    {
                //        Console.Write(armazenaNumeros[i][j]);
                //    }
                //}
            }

            //---------------
            //Ex03

            {
                //int[][] armazenaNumeros = new int[4][];
                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    armazenaNumeros[i] = new int[4]; 
                //}                

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    Console.WriteLine();
                //    for (int j = 0; j < armazenaNumeros[i].Length; j++)
                //    {
                //        Console.Write($"{i},{j}/");
                //    }
                //}
            }

            //---------------
            //Ex04

            {
                //int[][] armazenaNumeros = new int[5][];
                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    armazenaNumeros[i] = new int[5];
                //}
                //int valorAleatorio;

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    for (int j = 0; j < armazenaNumeros[i].Length; j++)
                //    {
                //        Console.WriteLine("Digite um valor:");
                //        valorAleatorio = Convert.ToInt32(Console.ReadLine());
                //        armazenaNumeros[i][j] = valorAleatorio;
                //        Console.Clear();
                //    }
                //}

                //bool achei = false;                
                //Console.WriteLine("Digite um valor para saber se ele se econtra na matriz");
                //valorAleatorio = Convert.ToInt32(Console.ReadLine());

                //for (int i = 0; i < armazenaNumeros.Length; i++)
                //{
                //    for (int j = 0; j < armazenaNumeros[i].Length; j++)
                //    {
                //        if (valorAleatorio == armazenaNumeros[i][j])
                //        {
                //            achei = true;
                //            Console.WriteLine($"O número se encontra na linha {i}, coluna {j}.");
                //            break;
                //        }

                //    }
                //    if(achei == true)
                //    {
                //        break;
                //    }
                //}
                //if (achei == false)
                //{
                //    Console.WriteLine("Número não encontrado.");
                //}             
            }

            //---------------
            //Ex05

            {
                //int valorAleatorio;
                //int maiorValorA = int.MinValue;
                //int maiorValorB = int.MinValue;

                //int[][] matrizUm = new int[4][];
                //for (int i = 0; i < matrizUm.Length; i++)
                //{
                //    matrizUm[i] = new int[4];
                //}

                //int[][] matrizDois = new int[4][];
                //for (int i = 0; i < matrizDois.Length; i++)
                //{
                //    matrizDois[i] = new int[4]; 
                //}

                //int[][] matrizTres= new int[4][];
                //for (int i = 0; i < matrizTres.Length; i++)
                //{
                //    matrizTres[i] = new int[4]; 
                //}

                //for (int i = 0; i < matrizUm.Length; i++)
                //{
                //    for (int j = 0; j < matrizUm[i].Length; j++)
                //    {
                //        Console.WriteLine($"Digite um valor para a posição {i}, {j} (MATRIZ 1)");
                //        valorAleatorio = Convert.ToInt32(Console.ReadLine());
                //        valorAleatorio = matrizUm[i][j];
                //        Console.Clear();
                //    }
                //}

                //for (int i = 0; i < matrizDois.Length; i++)
                //{
                //    for (int j = 0; j < matrizDois[i].Length; j++)
                //    {
                //        Console.WriteLine($"Digite um valor para a posição {i}, {j} (MATRIZ 2)");
                //        valorAleatorio = Convert.ToInt32(Console.ReadLine());
                //        valorAleatorio = matrizDois[i][j];
                //        Console.Clear();
                //    }
                //}

                //for (int i = 0; i < matrizUm.Length; i++)
                //{
                //    for (int j = 0; j < matrizUm[i].Length; j++)
                //    {
                //        if (maiorValorA < matrizUm[i][j])
                //        {
                //            maiorValorA = matrizUm[i][j];
                //        }                        
                //    }
                //}

                //for (int i = 0; i < matrizDois.Length; i++)
                //{
                //    for (int j = 0; j < matrizDois[i].Length; j++)
                //    {
                //        if (maiorValorB < matrizDois[i][j])
                //        {
                //            maiorValorB = matrizDois[i][j];
                //        }
                //    }
                //}
            }

            //---------------
            //Ex06

            {
                //double[][] matrizInteiros = new double[10][];
                //for (int i = 0; i < matrizInteiros.Length; i++)
                //{
                //    matrizInteiros[i] = new double[10];
                //}

                //for (int i = 0; i < matrizInteiros.Length; i++)
                //{
                //    for (int j = 0; j < matrizInteiros[i].Length; j++)
                //    {
                //        if (i < j)
                //        {
                //            double soma = 2 * i + 7 * j;
                //            double somaFinal = soma - 2;
                //            matrizInteiros[i][j] = somaFinal;
                //        }
                //        else if (i == j)
                //        {
                //            double soma = 3 * i ;
                //            double somaFinal = soma - 1;
                //            matrizInteiros[i][j] = somaFinal;
                //        }
                //        else
                //        {
                            
                //            double soma = 4 * i * j + 1;
                //            double somaFinal = soma - 5;
                //            matrizInteiros[i][j] = somaFinal;
                //        }
                //    }
                //}
                //for (int i = 0; i < matrizInteiros.Length; i++)
                //{
                //    Console.Write("\n");
                //    for (int j = 0; j < matrizInteiros[i].Length; j++)
                //    {
                //        Console.Write(matrizInteiros[i][j] + "/");
                //    }
                //}
             
            }

            //---------------
            //Ex07

            {
                int valorAleatorio;
                int soma = 1;

                int[][] matriz1 = new int[3][];
                for (int i = 0; i < matriz1.Length; i++)
                {
                    matriz1[i] = new int[3];
                }
                
                int[][] matriz2 = new int[3][];
                for (int i = 0; i < matriz2.Length; i++)
                {
                    matriz2[i] = new int[3];
                }


                for (int i = 0; i < matriz1.Length; i++)
                {
                    for (int j = 0; j < matriz1[i].Length; j++)
                    {
                        Console.WriteLine("Digite um número para matriz1");
                        valorAleatorio = Convert.ToInt32(Console.ReadLine());
                        valorAleatorio = matriz1[i][j];
                    }
                }

                Console.Clear();

                for (int i = 0; i < matriz2.Length; i++)
                {
                    for (int j = 0; j < matriz2[i].Length; j++)
                    {
                        Console.WriteLine("Digite um número para matriz2");
                        valorAleatorio = Convert.ToInt32(Console.ReadLine());
                        valorAleatorio = matriz2[i][j];
                    }
                }

                for (int i = 0; i < matriz1.Length; i++)
                {
                    for (int j = 0; j < matriz1[i].Length; j++)
                    {
                        if (j > i)
                        {
                            soma += matriz1[i][j];
                        }
                    }
                }
                
                for (int i = 0; i < matriz2.Length; i++)
                {
                    for (int j = 0; j < matriz2[i].Length; j++)
                    {
                        if (j > i)
                        {
                            soma = matriz2[i][j];
                        }
                    }
                }

                for (int i = 0; i < matriz1.Length; i++)
                {
                    Console.WriteLine(  );
                    for (int j = 0; j  < matriz1[i].Length; j ++)
                    {
                        Console.WriteLine(matriz1[i][j]);
                    }
                }


                Console.WriteLine(soma);
            }























            Console.ReadLine();
        }
    }
}










