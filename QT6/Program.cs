/*-------------------------------------------------------------------
Questão 6: Conversão de Moeda do Jogo
• Contextualização: O jogo possui uma loja onde os jogadores podem trocar moedas de ouro por
  cristais.
• Comando: Desenvolva um programa que receba o valor de moedas de ouro, o valor da taxa de
  conversão (1 cristal = X moedas de ouro), e dois bônus de conversão (um baseado em eventos
  e outro em habilidades), e calcule o número de cristais que o jogador pode obter.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
using System.Threading.Channels;
class Program {
    static void Main(string[] args) {
        int moedas, conversao;
        double cristais, bonusEvento, bonusHab;

        Console.Write("Quantas moedas? ");
        int.TryParse(Console.ReadLine(), out moedas);
        Console.Write("Qual a taxa de conversão? ");
        int.TryParse(Console.ReadLine(), out conversao);
        Console.Write("Qual o bônus de evento? ");
        double.TryParse(Console.ReadLine(), out bonusEvento);
        Console.Write("Qual o bônus de habilidade? ");
        double.TryParse(Console.ReadLine(), out bonusHab);

        cristais = moedas / conversao * bonusEvento * bonusHab;

        Console.WriteLine($"A quantidade de cristais é de: {cristais}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}