/*-------------------------------------------------------------------
Questão 3: Cálculo de Vida Restante
• Contextualização: Durante um combate, o jogador recebe dano e a vida do personagem
  diminui.
• Comando: Crie um programa que receba o valor da vida inicial, o dano recebido, o bônus de
  regeneração, do atacado, e dois modificadores, do atacante, (um para equipamentos e outro
  para habilidades), e calcule a vida restante.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int vida, dano, regen;
        double multEquip, multHab, vidaAtual;

        Console.WriteLine("Digite a vida: ");
        int.TryParse(Console.ReadLine(), out vida);
        Console.WriteLine("Digite o dano: ");
        int.TryParse(Console.ReadLine(), out dano);
        Console.WriteLine("Digite a regeneração: ");
        int.TryParse(Console.ReadLine(), out regen);
        Console.WriteLine("Digite o multiplicador de equipamentos: ");
        double.TryParse(Console.ReadLine(), out multEquip);
        Console.WriteLine("Digite o multiplicador de habilidades: ");
        double.TryParse(Console.ReadLine(), out multHab);

        vidaAtual = (vida - dano * multEquip * multHab) + regen;

        Console.WriteLine($"A vida atual é de: {vidaAtual}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}