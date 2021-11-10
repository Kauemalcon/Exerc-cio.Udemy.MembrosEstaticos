using System;
using System.Globalization;

namespace Exercícios_Array_Vetor_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------1--Exercício-----------Vetores---------------------------------------

            //Fazer um programa para ler um número inteiro N e a altura de N pessoas.
            //Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.

            //Console.WriteLine("Digite um numero inteiro para calcular a media de altura");
            //int numero = int.Parse(Console.ReadLine());
            //decimal[] vetor = new decimal[numero];
            //// Criando o loop do vetor
            //for (int inicio = 0; inicio < numero; inicio ++)
            //{
            //    vetor[inicio] = decimal.Parse(Console.ReadLine());
            //}

            //decimal soma = 0m;
            //// Empilhndo os valores da altura em um vetor
            //for (int inicio = 0; inicio < numero; inicio++)
            //{
            //    soma += vetor[inicio];
            //}
            //// altura media
            //decimal alturaMedia = soma / numero;
            //Console.WriteLine("\n Altura medía é: "+ alturaMedia.ToString("F2"));



            //-----------2--Exercício-----------Vetores---------------------------------------------
            // Fazer um programa para ler um número inteiro N e os dados(nome e preço) de N Produtos.
            //  Armazene os N produtos em um vetor.Em seguida, mostrar o preço médio dos produtos.


            //Console.WriteLine("digite um numero inteiro conforme a quantidade de dados(nome,preco)");
            //int numero = int.Parse(Console.ReadLine());

            ////Cria um array do tipo classe Product.cs para armazenamento de dados (produto e preco)
            //Product[] vetor = new Product[numero];

            //for (int inicio = 0; inicio < numero; inicio++)
            //{
            //    string nomeProduto = Console.ReadLine();
            //    double precoProduto = double.Parse(Console.ReadLine());

            ////Product armazenando dados  (nome e preco)
            //    vetor[inicio] = new Product { Nome = nomeProduto, Preco = precoProduto};
            //}
            //double soma = 0.0;
            //for (int inicio =0; inicio < numero; inicio++)
            //{
            //    soma += vetor[inicio].Preco;
            //}
            //double mediaProduto = soma / numero;
            //Console.WriteLine("Media dos produto: "+ mediaProduto);



            //-----------3--Exercício-----------Vetores----------------------------------------------------
            // A dona de um pensionato possui dez quartos para alugar para estudantes,
            //sendo esses quartos identificados pelos números 0 a 9.
            // Quando um estudante deseja alugar um quarto, deve - se registrar o nome e email deste estudante.
            //Fazer um programa que inicie com todos os dez quartos vazios, e depois
            //leia uma quantidade N representando o número de estudantes que vão
            //alugar quartos(N pode ser de 1 a 10).Em seguida, registre o aluguel dos
            //N estudantes. Para cada registro de aluguel, informar o nome e email do
            // estudante, bem como qual dos quartos ele escolheu(de 0 a 9).Suponha
            //que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
            //um relatório de todas ocupações do pensionato, por ordem de quarto conforme exemplo.


            Estudante[] vect = new Estudante[10];
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Estudante(nome, email);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }

            }
        }
    }
}
