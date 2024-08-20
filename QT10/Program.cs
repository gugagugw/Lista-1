/*-------------------------------------------------------------------
Questão 10: Atualização de Pontos de Vida
• Contextualização: Em um jogo de estratégia, um personagem pode ganhar pontos de vida a
  cada nível alcançado.
• Comando: Desenvolva um programa que receba os pontos de vida iniciais e o aumento de vida
  por nível, e calcule a quantidade de pontos de vida após alcançar um novo nível.


@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int vidaInicio, aumento, nivelAtual, vidaFinal;

        System.Console.WriteLine("Qual a vida inicial?");
        int.TryParse(Console.ReadLine(), out vidaInicio);
        System.Console.WriteLine("Qual o aumento por nível?");
        int.TryParse(Console.ReadLine(), out aumento);
        System.Console.WriteLine("Qual o nível alcançado?");
        int.TryParse(Console.ReadLine(), out nivelAtual);

        vidaFinal = vidaInicio + (aumento * nivelAtual);

        System.Console.WriteLine($"A vida final é de: {vidaFinal}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}