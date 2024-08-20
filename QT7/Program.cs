/*-------------------------------------------------------------------
Atividade 7: Experiência e Nível do Jogador após Batalha
• Contextualização: Em um jogo, o jogador enfrenta dois tipos diferentes de inimigos em uma
  batalha. Cada tipo de inimigo concede uma quantidade específica de XP. Após a batalha, o
  jogador ganha esse XP e precisa somá-lo ao XP total acumulado para determinar o nível atual
  do personagem.
• Comando:Desenvolva um programa que receba a quantidade de XP acumulado, o XP concedido
  pelo primeiro tipo de inimigo, o XP concedido pelo segundo tipo de inimigo, o número de cada
  tipo de inimigo derrotado, e a constante de nível. O programa deve calcular o XP total
  acumulado após a batalha e determinar o nível atual do jogador.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int xpAcumulado, xpInimigo1, inimigo1Derrotado, xpInimigo2, inimigo2Derrotado, xpTotal, nivel;
        const int constanteNivel = 100;

        Console.WriteLine("Qual o XP acumulado?");
        int.TryParse(Console.ReadLine(), out xpAcumulado);
        Console.WriteLine("Qual o XP dado pelo inimigo 1?");
        int.TryParse(Console.ReadLine(), out xpInimigo1);
        Console.WriteLine("Quantos inimigos 1 foram derrotados?");
        int.TryParse(Console.ReadLine(), out inimigo1Derrotado);
         Console.WriteLine("Qual o XP dado pelo inimigo 2?");
        int.TryParse(Console.ReadLine(), out xpInimigo2);
        Console.WriteLine("Quantos inimigos 2 foram derrotados?");
        int.TryParse(Console.ReadLine(), out inimigo2Derrotado);

        xpInimigo1 = xpInimigo1 * inimigo1Derrotado;
        xpInimigo2 = xpInimigo2 * inimigo2Derrotado;
        xpTotal = xpAcumulado + xpInimigo1 + xpInimigo2;
        nivel = xpTotal / constanteNivel;

        System.Console.WriteLine($"O nível do personagem é: {nivel}\nE o XP total: {xpTotal}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}