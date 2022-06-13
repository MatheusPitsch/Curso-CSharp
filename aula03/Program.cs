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

            //6) Imagine que uma escola deseja cadastrar alunos para isso ,Crie 3 vetores de 4 posições / tamanho 4, um para os nome, outro para cpf, e outro para idade, primeiro, mostre para o usuario em ordem, os alunos ja armazenados, entao, o usuario escolhe em qual lugar ele deseja armazenar um novo aluno(ex: usuario escolheu 2 , pede - se um nome, cpf e idade, entao, coloque tudo isso na 2° posição dos tres vetores)
            //ao terminar de colocar aluno, pede - se ao usuario se deseja colocar um novo aluno ou sair.

            //7) Vamos criar um sistema simplificado de um estacionamento, para isso, Crie 2 vetores de 10 posições(estes vetores representam o numero de vagar, 10 vagas), um para a placa(possui letras e numeros) e outro para a hr de entrada, ao iniciar, solicite ao usuario se o cliente esta entrando ou sainda para isso:
            //        Entrando: Primeiro confere se tem vagas disponíveis, se nao, apenas avise que nao tem vagas e volte ao inicio, caso tenha, peça a placa e a hora de entrada, então, armazene na primeira vaga livre
            //Saindo: Peça a placa do carro, se a placa nao for encontrada peça novamente, caso encontrou a placa, calcule o valor a ser pago(custa R$ 3, 50 a hora), após isso, zere a vaga que o cliente estava ocupando.

            //-------------////-------------//
            //1
            {
                //int[] vetor = new int[2];

                //for (int i = 0; i < vetor.Length; i++)
                //{
                //    System.Console.WriteLine("Digete um valor");
                //    vetor[i]  = System.Convert.ToInt32(System.Console.ReadLine());

                //} 
                //  if (vetor[0] > vetor[1])
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
                int[] vetor = new int[3];

                for (int i = 0; i < vetor.Length; i++)
                {
                    System.Console.WriteLine("Digite a " + i + "° nota do aluno(a)");
                    vetor[i] = System.Convert.ToInt32(System.Console.ReadLine());
                }

                double soma = 0;
                double media = 0;

                for(int i = 0; i < vetor.Length; i++)
                {
                    soma += vetor[i];

                    media = soma / 3;
                }

                System.Console.WriteLine({0:D} media);
            }
            System.Console.ReadLine();
        }
    }
}
