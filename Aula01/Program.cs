using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //.tostring(); serve para transformar um int em string.
            // Se você somar junto com o tostring acontece uma contatenação
            //.Convert serve para converter para akgum tipo (Ex:Convert.Int32(input1);) -> Melhor modo de usar para converção
            //Outro exemplo de converção numero1 = Convert.ToInt32(Readline());

            {/* 
            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---//---");
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);

            Console.ReadLine();
        */
            }

            {/*
                double cotacao;
                double dinheiro;

                Console.WriteLine("Digite o valor da cotação");
                cotacao = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("------//-------");
                Console.WriteLine("Cotação de hoje:" + cotacao);
                Console.WriteLine("Diga o valor que você quer converter");
                dinheiro = Convert.ToDouble(Console.ReadLine());

                var somaFinal = cotacao * dinheiro;

                Console.WriteLine(somaFinal);
                Console.ReadLine();
               */
            }
            /*
            a) Declarar uma variável A, ler um valor para ela e escrever o valor da variável A em seguida.

            b) Escreva um algoritmo que solicita ao usuário 3 valores inteiros via teclado e depois exibe os números fornecidos.

            c) Efetuar a leitura de um número inteiro e apresentar o resultado do quadrado desse número.

            d) Ler dois valores inteiros (variáveis A e B) e apresentar o resultado do quadrado do primeiro valor (variável A) mais o quadrado do segundo valor (variável B).

            e) Elaborar um programa que efetue a apresentação do valor da conversão em real (R$) de um valor lido em dólar (US$). O programa deverá solicitar o valor da cotação do dólar e também a quantidade de dólares disponível com o usuário.

            f) Elaborar um programa que efetue a apresentação do valor da conversão em dólar (US$) de um valor lido em real (R$). O programa deverá solicitar o valor da cotação do dólar e também a quantidade de reais disponível com o usuário.

            g) Os artigos de uma loja possuem um valor associado a si. Na compra a vista, é concedido um desconto de 8% mas, comprando em 3 vezes há um acréscimo de 15% no valor do artigo. Faça um algoritmo que tendo como entrada o valor do artigo, mostre como resultado o valor a vista e o valor das parcelas a prazo.

            h) Ler dois valores para as variáveis A e B, e efetuar a troca dos valores de forma que a variável A passe a possuir o valor da variável B e a variável B passe a possuir o valor da variável A. Apresentar os valores trocados.
            */

            //------------------//----------------
            //Exercicio C
            {
                //int valor1;

                //Console.WriteLine("Digite um valor");
                //valor1 = Convert.ToInt32(Console.ReadLine());

                //var soma = valor1 * valor1;

                //Console.WriteLine(soma);
                //Console.ReadLine();

            }
            //------------------//----------------
            //Exercicio D
            {
                //Console.WriteLine("Digite um valor 1");
                //int valor1 = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Digite um valor 2");
                //int valor2 = Convert.ToInt32(Console.ReadLine());

                //var quadradoValor1 = valor1 * valor1;
                //var quadradoValor2 = valor2 * valor2;

                //var resultadoFinal = quadradoValor1 + quadradoValor2;

                //Console.WriteLine("A soma dos quadrados dos valor é " + resultadoFinal);
                //Console.ReadLine();

            }
            //------------------//----------------
            //Exercicio F
            {/*
                Console.WriteLine("Diga a cotação do dolar");
                double cotacao = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Diga o valor para converter");
                double dolar = Convert.ToDouble(Console.ReadLine());

                var soma = dolar / cotacao;

                Console.WriteLine(soma);
                Console.ReadLine();
                */
            }
            //------------------//----------------
            //Exercicio G
            {

                Console.WriteLine("Diga o valor do artigo");
                double valorArtigo = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("--FORMA DE PAGAMENTO--");
                Console.WriteLine("Diga a forma de pagamento:");
                Console.WriteLine("1-Avista");
                Console.WriteLine("2-Cretido");
                int formaPagamento = Convert.ToInt32(Console.ReadLine());

                if (formaPagamento == 1)
                {
                    double porcentagem = 8.0 / 100;
                    double desconto = valorArtigo - (valorArtigo * porcentagem);
                    Console.WriteLine("O valor do artigo com 8% de desconto é R$" + desconto);
                    Console.ReadLine();
                }
                else if (formaPagamento == 2)
                {
                    Console.WriteLine("Digite em quantas vezes");
                    int vezes = Convert.ToInt32(Console.ReadLine());
                    if (vezes >= 3)
                    {
                        double porcentagem = 15.0 / 100;
                        double acrescimo = valorArtigo + (valorArtigo * porcentagem);
                        double parcela = acrescimo / vezes;
                        Console.WriteLine("O valor do artigo é de R$" + acrescimo + ", dividido em " + vezes + " vezes o valor da parcela será de R$" + parcela);
                        Console.ReadLine();
                    }
                    else
                    {
                        double parcela = valorArtigo / vezes;
                        Console.WriteLine("O valor do artigo é de R$" + valorArtigo + ", dividido em " + vezes + " vezes, o valor da parcela será de R$" + parcela);
                        Console.ReadLine();
                    }



                }
                //------------------//----------------
                //Exercicio H
                {/*
                Console.WriteLine("Digite o valore de A");
                string a = Console.ReadLine();
                Console.WriteLine(a);

                Console.WriteLine("Digite o valore de B");
                string b = Console.ReadLine();
                Console.WriteLine(b);
                
                Console.WriteLine("---Divisão---");
                string aux = a;
                a = b;
                b = aux;

                Console.WriteLine("Valor de A: "+a);
                Console.WriteLine("Valor de B: "+b);
                Console.ReadLine();
                */
                }





            }
        }
    }
}
