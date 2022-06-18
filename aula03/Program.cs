namespace aulaa03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) Crie um vetor que armazena 2 valores vindo do usuario, depois, diga pro usuario qual o maior

            //2) Crie um vetor que armarmazene 3 notas vindo do usuario, depois, de a média das três notas

            //3) Crie um vetor que armazena 3 valores vindo do usuario, depois, mostre apenas o maior dentre eles, se todos forem iguais, exiba uma mensagem dizendo “sao todos iguais”

            //4) Crie um vetor que armazena 3 nomes vindo do usuario, o usuario pode, a qualquer momento, solicitar quais nomes estao armazenados.

            //5) Crie um vetor que armazena 5 valor INTEIROS, peça ao usuario para ele colocar valores nessas 5 posições, depois, some todos os valor e mostre pro usuario

            //6) Imagine que uma escola deseja cadastrar alunos para isso ,Crie 3 vetores de 4 posições / tamanho 4, um para os nome,
            //outro para cpf, e outro para idade, primeiro, mostre para o usuario em ordem, os alunos ja armazenados, entao,
            //o usuario escolhe em qual lugar ele deseja armazenar um novo aluno(ex: usuario escolheu 2 , pede - se um nome, cpf e idade,
            //entao, coloque tudo isso na 2° posição dos tres vetores)
            //ao terminar de colocar aluno, pede - se ao usuario se deseja colocar um novo aluno ou sair.

            //7) Vamos criar um sistema simplificado de um estacionamento, para isso, Crie 2 vetores de 10 posições
            //(estes vetores representam o numero de vagar, 10 vagas), um para a placa(possui letras e numeros) e outro para a hr de entrada,
            //ao iniciar, solicite ao usuario se o cliente esta entrando ou sainda para isso:
            //Entrando: Primeiro confere se tem vagas disponíveis, se nao, apenas avise que nao tem vagas e volte ao inicio, caso tenha,
            //peça a placa e a hora de entrada, então, armazene na primeira vaga livre
            //Saindo: Peça a placa do carro, se a placa nao for encontrada peça novamente, caso encontrou a placa,
            //calcule o valor a ser pago(custa R$ 3, 50 a hora), após isso, zere a vaga que o cliente estava ocupando.

            //-------------////-------------//
            //1
            {
                //int[] vetor = new int[2];

                //for (int i = 0; i < vetor.Length; i++)
                //{
                //    System.Console.WriteLine("Digete um valor");
                //    vetor[i] = System.Convert.ToInt32(System.Console.ReadLine());

                //}
                //if (vetor[0] > vetor[1])
                //{
                //    System.Console.WriteLine("O maior número esta na posição 0 que é o " + vetor[0]);
                //}
                //else
                //{
                //    System.Console.WriteLine("O maior número esta na posição 1 que é o " + vetor[1]);
                //}
                //System.Console.ReadLine();
            }
            //-------------////-------------//
            //2
            {
                //double[] vetor = new double[3];

                //for (int i = 0; i < vetor.Length; i++)
                //{
                //    System.Console.WriteLine("Digite a " + i + "° nota do aluno(a)");
                //    vetor[i] = System.Convert.ToDouble(System.Console.ReadLine());
                //}

                //double soma = 0;
                //double media = 0;

                //for (int i = 0; i < vetor.Length; i++)
                //{
                //    soma += vetor[i];
                //}

                //media = soma / vetor.Length;

                //System.Console.WriteLine("Meida = " + "{0:f}", media);
            }
            //-------------////-------------//
            //3
            {
                //int[] vetor = new int[3];

                //for (int i = 0; i < vetor.Length; i++)
                //{
                //    System.Console.WriteLine("Digite um valor");
                //    vetor[i] = System.Convert.ToInt32(System.Console.ReadLine());
                //}
                //int valorMaior = 0;

                //if (vetor[0] == vetor[1] && vetor[1] == vetor[2])
                //{
                //    System.Console.WriteLine("Os valores são iguais");
                //}
                //else
                //{
                //    for (int i = 0; i < vetor.Length; i++)
                //    {
                //        if (i == 0)
                //        {
                //            valorMaior = vetor[i];
                //        }
                //        else if (vetor[i] > valorMaior)
                //        {
                //            valorMaior = vetor[i];
                //        }
                //    }
                //    System.Console.WriteLine("O maior valor é " + valorMaior);
                //}
            }
            //-------------////-------------//
            //4
            {
                //string[] vetorNomes = new string[3];
                //int opcao = 0;
                //int indice = 0;
                //bool sair = true;

                //while (sair)
                //{
                //    System.Console.WriteLine("Escolha uma opção:\n\n1-Adicionar um nome na lista\n2-Mostrar Lista\n3-Sair");
                //    opcao = System.Convert.ToInt32(System.Console.ReadLine());
                //    System.Console.Clear();

                //    switch (opcao)
                //    {
                //        case 1:
                            
                //            if (vetorNomes[2] == null)
                //            {
                //                System.Console.WriteLine("Digite o nome da pessoa.");
                //                vetorNomes[indice] = System.Console.ReadLine();
                //                indice++;
                //                System.Console.Clear();
                //            }
                //            else
                //            {
                //                System.Console.WriteLine("A lista ja esta cheia.");
                //            }
                            

                //            break;

                //        case 2:

                //            for (int i = 0; i < vetorNomes.Length; i++)
                //            {
                //                System.Console.WriteLine(vetorNomes[i]);
                //            }
                //            System.Console.ReadLine();
                //            System.Console.Clear();
                //            break;

                //        case 3:

                //            sair = false;
                //            break;

                //        default:
                //            System.Console.WriteLine("Opção Invalida");
                //            System.Console.ReadLine();
                //            System.Console.Clear();
                //            break;
                //    }

                //}
            }
            //-------------////-------------//
            //5
            {
                //int[] vetorNumeros = new int[5];
                //int soma = 0;

                //for (int i = 0; i < vetorNumeros.Length; i++)
                //{
                //    System.Console.WriteLine("Digite um número:");
                //    vetorNumeros[i] = System.Convert.ToInt32(System.Console.ReadLine());
                //    soma += vetorNumeros[i];

                //}

                //System.Console.WriteLine("A soma dos valores é " + soma);
            }
            //-------------////-------------//
            //6
            {
                string[] vetorNomes = new string[4];
                string[] vetorCpf = new string[4];
                string[] vetorIdade = new string[4];
                bool sair = true;
                int opcao = 0;
                int indice = 0;

                while (sair)
                {
                    System.Console.WriteLine("Escolha uma opção\n\n1-Cadastrar Pessoa\n2-Mostrar Pessoas\n3-Sair\n");
                    opcao = System.Convert.ToInt32(System.Console.ReadLine());
                    System.Console.Clear();

                    switch (opcao)
                    {
                        case 1:
                            for (int i = 0; i < vetorNomes.Length; i++)
                            {
                                System.Console.WriteLine(i + 1 + "-" + vetorNomes[i]);
                            }
                            System.Console.WriteLine("Escolha um número:");
                            indice = System.Convert.ToInt32(System.Console.ReadLine());
                            System.Console.Clear();

                            System.Console.WriteLine("Digite o nome:");
                            vetorNomes[indice - 1] = System.Console.ReadLine();

                            System.Console.WriteLine("Digite o Cpf:");
                            vetorCpf[indice - 1] = System.Console.ReadLine();

                            System.Console.WriteLine("Digite a Idade:");
                            vetorIdade[indice - 1] = System.Console.ReadLine();

                            System.Console.Clear();
                            break;

                        case 2:
                            for (int i = 0; i < vetorNomes.Length; i++)
                            {

                                System.Console.WriteLine("Nome: {0},\nCpf: {1},\nIdade: {2}",vetorNomes[i], vetorCpf[i], vetorIdade[i]);
                                System.Console.WriteLine("=====//=====");
                            }

                            System.Console.ReadLine();
                            System.Console.Clear();

                            break;

                        case 3:

                            sair = false;

                            break;

                        default:
                            System.Console.WriteLine("Opção Invalida.");
                            break;
                    }
                }

            }
            //-------------////-------------//
            //7
            {
                //string[] placas = new string[10];
                //string[] horaEntrada = new string[10];
                //int opcao = 0;
                //string placa;
                //bool sair = true;

                //while (sair)
                //{
                //    System.Console.WriteLine("------ESTACIONAMENTO-----\n\n1-Entreando\n2-Saindo\n3-Sair\n");
                //    opcao = System.Convert.ToInt32(System.Console.ReadLine());
                //    System.Console.Clear();

                //    switch (opcao)
                //    {
                //        case (1):

                //            for (int i = 0; i < placas.Length; i++)
                //            {
                //                if (placas[i] == null)
                //                {
                //                    System.Console.WriteLine("A vaga número " + i + " está disponivel.\n");

                //                    System.Console.WriteLine("Diga-nos sua placa\n");
                //                    placas[i] = System.Console.ReadLine();
                //                    System.Console.Clear();

                //                    System.Console.WriteLine("Diga o horario de entrada\n");
                //                    horaEntrada[i] = System.Console.ReadLine();
                //                    System.Console.Clear();
                //                    break;

                //                }
                //                else if (i == 9)
                //                {
                //                    System.Console.WriteLine("\nNão temos vagas disponiveis.\n");
                //                    System.Console.ReadLine();
                //                    System.Console.Clear();
                //                }
                //            }

                //            break;

                //        case (2):

                //            System.Console.WriteLine("Digite sua placa\n");
                //            placa = System.Console.ReadLine();

                //            for (int i = 0; i < placas.Length; i++)
                //            {
                //                if (placas[i] == placa)
                //                {
                //                    System.Console.WriteLine("O valor do estacionamneto ficou R$3,5.\n");

                //                    placas[i] = null;
                //                    horaEntrada[i] = null;
                //                    break;
                //                }
                //                else
                //                {
                //                    System.Console.WriteLine("Digite a placa novamente\n");
                //                    break;
                //                }
                //            }

                //            System.Console.ReadLine();
                //            System.Console.Clear();

                //            break;

                //        case (3):

                //            sair = false;

                //            break;

                //        default:

                //            System.Console.WriteLine("Opção Invaldia\n");
                //            System.Console.ReadLine();
                //            System.Console.Clear();

                //            break;
                //    }

                //}

            }

            System.Console.ReadLine();
        }
    }
}
