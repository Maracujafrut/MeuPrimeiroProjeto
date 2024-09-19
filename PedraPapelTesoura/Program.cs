﻿// See https://aka.ms/new-console-template for more information
using System;

class PedraPapelTesoura
{
    static void Main(string[] args)
    {
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };
        Random random = new Random();
        bool jogarNovamente = true;
        int vitoriasUsuario = 0, vitoriasComputador = 0, empates = 0;

        while (jogarNovamente)
        {
            Console.WriteLine("Escolha uma opção: (0) Pedra, (1) Papel, (2) Tesoura");
            int escolhaUsuario;

            // Verifica se a entrada do usuário é válida
            while (!int.TryParse(Console.ReadLine(), out escolhaUsuario) || escolhaUsuario < 0 || escolhaUsuario > 2)
            {
                Console.WriteLine("Entrada inválida. Tente novamente: (0) Pedra, (1) Papel, (2) Tesoura");
            }

            int escolhaComputador = random.Next(3);

            Console.WriteLine($"\nVocê escolheu: {opcoes[escolhaUsuario]}");
            Console.WriteLine($"Computador escolheu: {opcoes[escolhaComputador]}\n");

            if (escolhaUsuario == escolhaComputador)
            {
                Console.WriteLine("Empate!");
                empates++;
            }
            else if ((escolhaUsuario == 0 && escolhaComputador == 2) ||
                     (escolhaUsuario == 1 && escolhaComputador == 0) ||
                     (escolhaUsuario == 2 && escolhaComputador == 1))
            {
                Console.WriteLine("Você venceu!");
                vitoriasUsuario++;
            }
            else
            {
                Console.WriteLine("O computador venceu!");
                vitoriasComputador++;
            }

            // Exibir o placar
            Console.WriteLine($"\nPlacar: Você {vitoriasUsuario} x {vitoriasComputador} Computador (Empates: {empates})\n");

            // Pergunta se o usuário quer jogar novamente
            Console.WriteLine("Deseja jogar novamente? (S/N)");
            string resposta = Console.ReadLine().ToUpper();
            jogarNovamente = resposta == "S";
            Console.WriteLine();
        }

        Console.WriteLine("Obrigado por jogar! Até a próxima.");
    }
}
