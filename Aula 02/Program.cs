using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//Aula02
                /*
                 Função random
                Random dado = new Ramdon();
                int resultado;
                resultado = dado.Next(1,6*1);
                 */

                /*ATIVIDADES

                2) Recebe dois números, apresente na tela “são iguais” caso sejam iguais, caso contrário apresente qualquer outra mensagem

                3) Receba dois valores, apresente na tela apenas o maior deles

                4) Receba três valores, apresente na tela apenas o maior deles

                5) Receba um número qualquer de entrada, se for 1 apresente na tela “1”, se 2 apresente “2”, se for 3 apresente “3” e se não for nenhuma das anteriores apresente “não computável” (use a função Switch)

                7) Receba um número, e informe se ele é par ou ímpar

                8) Receba um valor de produto, se o produto custar mais que R$254,50 deve-se aplicar um desconto de 28% e mostrar na tela o valor original e com desconto, caso contrário, o desconto deve ser de apenas 21% e mostrar na tela o valor original e com desconto

                10) Imagine que uma loja possui cartão fidelidade, além disso, tem descontos variadores para diferentes valores de compra, além disso, ela aplica um desconto extra para cada cinco compras, peça ao caixa dessa loja, o valor da compra,se tem cartão fidelidade e se esta é a quinta compra, então aplique os descontos na seguinte ordem: valor, cartão fidelidade e quinta compra
                A quantidade dos descontos é de : para compras entre 0,01 e 200,00 é de 0%, entre 200,01 e 400,00 é de 10 % e para compras acima de 400,00 é de 20%, O cartão fidelidade adiciona um desconto de 15% e se for a quinta compra mais 10% desconto,
                Desenvolva este algoritmo para a loja.
                 
                 */
                //2
                { /*int valorA, valorB;

                    Console.WriteLine("Digite o valor de A: ");
                    valorA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B: ");
                    valorB = Convert.ToInt32(Console.ReadLine());

                    if (valorA == valorB)
                    {
                        Console.WriteLine("Os valores são iguais");
                    }
                    else
                    {
                        Console.WriteLine("Os valores são diferentes");
                    }
                     */       
                }
                //------------//------------
                //3
                {/*
                    int valorA, valorB;
                    
                    Console.WriteLine("Digite o valor de A: ");
                    valorA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B: ");
                    valorB = Convert.ToInt32(Console.ReadLine());

                    if (valorA > valorB)
                    {
                        Console.WriteLine("O valor valorA é maior que valorB");
                    }
                    else if (valorB > valorA)
                    {
                        Console.WriteLine("O valor valorB é maior que valorA");
                    }
                    else
                    {
                        Console.WriteLine("Os valores são iguais");
                    }
                    */
                }
                //------------//------------
                //4
                {/*
                    int valorA, valorB, valorC;

                    Console.WriteLine("Digite o valor de A: ");
                    valorA = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de B: ");
                    valorB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o valor de C: ");
                    valorC = Convert.ToInt32(Console.ReadLine());

                    if (valorA > valorB && valorA > valorC)
                    {
                        Console.WriteLine("O valor valorA é maior que valorB e valorC");
                    }
                    else if (valorB > valorC)
                    {
                        Console.WriteLine("O valor valorB é maior que valorA e valorC");
                    }
                    else
                    {
                        Console.WriteLine("O valor valorC é maior que valorB e valorA");

                    }
                    */
                }
                //------------//------------
                //5
                {/*
                    int valorAleatorio;
                    Console.WriteLine("Digite um valor aleatorio");
                    valorAleatorio = Convert.ToInt32(Console.ReadLine());

                    switch (valorAleatorio)
                    {
                        case 1:
                            Console.WriteLine("1");
                            break;
                        case 2:
                            Console.WriteLine("2");
                            break;
                        case 3:
                            Console.WriteLine("3");
                            break;
                        default:
                            Console.WriteLine("Valor não encontrado");
                            break;
                    }
                    */
                }
                //------------//------------
                //7
                {/*
                    int valor;
                    Console.WriteLine("Digite um valor para saber se ele é par ou impar");
                    valor = Convert.ToInt32(Console.ReadLine());

                    if (valor % 2 == 0)
                    {
                        Console.WriteLine("O número é par");
                    }
                    else
                    {
                        Console.WriteLine("O número é impar");
                    }
                    */
                }
                //------------//------------
                //8
                {/*
                    double valorProduto;
                    double valorProdutoDesconto = 1;
                    Console.WriteLine("Digite o valor do produto");
                    valorProduto = Convert.ToDouble(Console.ReadLine());

                    if (valorProduto > 254.50)
                    {
                        valorProdutoDesconto = valorProduto - (0.28 * valorProduto);
                    }
                    else
                    {
                        valorProdutoDesconto = valorProduto - (0.21 * valorProduto);

                    }
                    Console.WriteLine("O valor do produto é " + valorProduto + ", o valor final com desconto ficara R$" + valorProdutoDesconto);
                    */
                }
                //------------//------------
                //10
                {/*
                    double valorCompra;
                    int possuicartao, quantidadeCompra;

                    Console.WriteLine("Digite o valor da compra");
                    valorCompra = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    
                    Console.WriteLine("O cliente possui o cartão fidelidade");
                    Console.WriteLine("\n\n1 - Possui\n\n2 - Não Possui");
                    possuicartao = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    
                    Console.WriteLine("Qunatas vezes eles ja comprou na loja?");
                    quantidadeCompra = Convert.ToInt32(Console.ReadLine());

                    if (valorCompra > 400)
                    {
                        valorCompra = valorCompra - (0.2 * valorCompra);
                    }
                    else if(valorCompra > 200)
                    {
                        valorCompra = valorCompra - (0.1 * valorCompra);
                    }
                    if ( possuicartao == 1)
                    {
                        valorCompra = valorCompra - (0.15 * valorCompra);
                    }
                    if (quantidadeCompra == 5)
                    {
                        valorCompra = valorCompra - (0.10 * valorCompra);
                    }

                    Console.WriteLine(valorCompra);
                    */
                }

                //------------//------------
                /*
                1) Eu gostaria de contar de 1 até 10, desenvolva um algoritmo que resolve meu problema

                2) Gostaria de saber todos os números pares entre 0 e 23, desenvolva um algoritmo que resolve meu problema

                3) Após receber um número do usuario, apresntar em ordem decrescente até 0

                4) Após receber um número do usuario, apresentar em ordem decrescente até 0, se o número for menor que 0 apresente em ordem crescente até 0

                5) Gostaria de saber se o número que coloquei no sistema é maior que 24, se for verdade, multiplique esse número por 2 e mostre na tela, se for maior que 0 apenas apresente na tela, se for menor ou igual a 0 peça para inserir o número novamente, use a palavra “exit” para parar o programa.  

                6) Uma escola precisa fazer o cadastro dos alunos, para isso, precisa-se: nome,cpf,endereço do aluno, para isso, aramezene todos esses valores em variáveis e então mostre na tela, em seguida, pergunte se a pessoa deseja cadastrar mais um aluno, isso se repete até a pessoa parar de adicionar
                ps: pode usar apenas 3 variaveis

                7) Faça um programa que testa o lançamento de um dado de 6 faces 30 vezes, para cada vez que o valor for maior ou igual a 3 eu ganho R$ 10,00 , se nao, eu perco R$ 15,00, no final, se o valor for positivo apresente na tela “você ganhou” + quanto ganhei, caso contrário, mostre “você perdeu” + quanto devo.

                8)Um supermercado resolveu inserir desconto baseado em produto e quantidade no carrinho/sexta , caso a compra tenha mais de 7 produtos tem 10% de desconto no valor final, além disso, caso tenho mais de 3 queijos na compra aplica-se 10% no valor total do queijo, o mesmo se aplica para o macarrão. Produtos a estarem na memória para poder fazer a compra depois,
                queijo(R$ 4,50), macarrão(R$ 5,00), feijão(R$ 4,00) , presunto(R$ 5,50), pão(R$ 3,75) após a compra, mostrar o valor final a ser pago.
                ps: pode-se adotar um sistema de ID para os produtos, exemplo: queijo = 1, macarrão = 2 etc… além disso, a compra acaba APENAS quando o usuario inserir “acabou” ou “fim”
*/
                //------------//------------
                //2
                {/*
                    for (int i = 0; i < 23; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                    }
                    */
                }
                //------------//------------
                //3
                {/*
                    int indice;
                    Console.WriteLine("Digite um valor");
                    indice = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {

                        Console.WriteLine(indice);

                        if (indice == 0)
                        {
                            break; 
                        }
                        indice -= 1;
                    
                    }
                    */
                }
                //------------//------------
                //4
                {/*
                    int indice;
                    Console.WriteLine("Digite um valor");
                    indice = Convert.ToInt32(Console.ReadLine());

                    if (indice > 0)
                    {
                        while (true)
                        {

                            Console.WriteLine(indice);

                            if (indice == 0)
                            {
                                break;
                            }
                            indice -= 1;

                        }
                    }
                    else
                    {
                        while (true)
                        {

                            Console.WriteLine(indice);

                            if (indice == 0)
                            {
                                break;
                            }
                            indice += 1;

                        }
                    }

                    
                    */
                }
                //------------//------------
                //5
                {/*

                    while (true)
                    {
                        int valor;
                        string sair = "";
                        Console.WriteLine("Digite um valor");
                        valor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Se desejar sair digite exit");
                        Console.Clear();

                        if (valor > 24)
                        {
                            valor = valor * 2;
                            Console.WriteLine(valor);
                        }
                        else if (valor > 0)
                        {
                            Console.WriteLine(valor);
                        }
                        else if (valor < 0 || valor == 0)
                        {
                            Console.WriteLine("Digite o valor novamente");
                            continue;
                        }
                        else if (sair == "exit")
                        {
                            break;
                        }
                        */
                    }
                //------------//------------
                //6
                { 
                    /*
                    while (true)
                    {
                        string nomeCpf, endereco;
                        int opcao;

                        Console.WriteLine("Digite o NOME e o CPF do(a) aluno(a)");
                        nomeCpf = Console.ReadLine();
                        Console.WriteLine("Digite o endereço do(a) aluno(a)");
                        endereco = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("escolha uma opção");
                        Console.WriteLine("\n1 - Mostrar ultimo aluno\n2 - cadastra outro aluno\n3 - sair");
                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao == 1)
                        {
                            Console.Clear();
                            Console.WriteLine(nomeCpf);
                            Console.WriteLine(endereco);
                            Console.WriteLine("\nEsolha um opção\n");
                            Console.WriteLine("1 - Cadastrar novo aluno \n2 - sair");
                            opcao = Convert.ToInt32(Console.ReadLine());
                            if (opcao == 1)
                            {
                                Console.Clear();
                                continue;
                            }
                            else if (opcao == 2)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Opção não existe");
                            }

                        }else if (opcao == 2)
                        {
                            continue;
                        }else if (opcao == 3)
                        {
                            break;
                        }
                    }
                */}
                //------------//------------
                //7
                {/* Verificar pois esta dando erro  
                    int dinheiro = 0;
                    for (int i = 0; i < 30; i++)
                    {
                        Random dado = new Random();
                        int resultado;
                        resultado = dado.Next(1, 6 * 1);

                        if (resultado >= 3)
                        {
                            dinheiro += 10;
                        }
                        else
                        {
                            dinheiro -= 15;
                        }
                    }
                    
                    if (dinheiro > 0)
                    {
                        Console.WriteLine("Você ganhou R$" + dinheiro);
                    }
                    else if (dinheiro < 0)
                    {
                        Console.WriteLine("Você esta devendo R$" + dinheiro);
                    }
                    else
                    {
                        Console.WriteLine("Você não ganhou nada.");
                    }*/
                }
                //------------//------------
                //8
                {
                    int opcao;

                    while (true)
                    {
                        Console.WriteLine("Escolha qual item deseja isirir no carrinho.");
                        Console.WriteLine("\n------CAIXA------\n");
                        Console.WriteLine("\n1 - Queijo");
                        Console.WriteLine("\n2 - Macarrão");
                        Console.WriteLine("\n3 - Feijão");
                        Console.WriteLine("\n4 - Presunto");
                        Console.WriteLine("\n5 - Pão\n");

                        opcao = Convert.ToInt32(Console.ReadLine());

                        if (opcao)
                        {

                        }
                    }
                }
            }
            Console.ReadLine();
            }
        }
    }
