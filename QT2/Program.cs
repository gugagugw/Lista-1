/*-------------------------------------------------------------------
Questão 2: Pontuação Final
• Contextualização: No final de uma missão em um jogo, a pontuação do jogador é calculada com
  base nos inimigos derrotados e pontos adicionais.
• Comando: Desenvolva um programa que receba o número de inimigos derrotados, a pontuação
  por inimigo, bônus por missão, e dois multiplicadores (um para tipo de inimigo e outro para
  dificuldade), e então calcule e exiba a pontuação final.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;

class Program 
{
    static void Main()
    {
        int inimigos, pontos, bonusMissao, multInimigo, multDificuldade, pontFinal;

        Console.WriteLine("Quantidade de inimigos derrotados: ");
        int.TryParse(Console.ReadLine(), out inimigos);
        Console.WriteLine("Quantidade de pontos por inimigos: ");
        int.TryParse(Console.ReadLine(), out pontos);
        Console.WriteLine("Quantidade de pontos bônus pela missão: ");
        int.TryParse(Console.ReadLine(), out bonusMissao);
        Console.WriteLine("Multiplicador do tipo de inimigo: ");
        int.TryParse(Console.ReadLine(), out multInimigo);
        Console.WriteLine("Multiplicador da dificuldade: ");
        int.TryParse(Console.ReadLine(), out multDificuldade);

        pontFinal = inimigos * pontos * multInimigo * multDificuldade + bonusMissao;

        Console.WriteLine($"A pontuação final é de: {pontFinal}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}