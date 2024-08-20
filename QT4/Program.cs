/*-------------------------------------------------------------------
Questão 4: Somatório de Moedas
• Contextualização: No seu jogo, o jogador coleta moedas durante uma fase. A cada coleta, o total
  de moedas aumenta.
• Comando: Desenvolva um programa que receba cinco valores de moedas coletadas e some-os,
  exibindo o total de moedas coletadas ao final.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int moedas1, moedas2, moedas3, moedas4, moedas5, moedasTotal;

        Console.Write("Quantas moedas foram coletadas na 1° fase? ");
        int.TryParse(Console.ReadLine(), out moedas1);
        Console.Write("Quantas moedas foram coletadas na 2° fase? ");
        int.TryParse(Console.ReadLine(), out moedas2);
        Console.Write("Quantas moedas foram coletadas na 3° fase? ");
        int.TryParse(Console.ReadLine(), out moedas3);
        Console.Write("Quantas moedas foram coletadas na 4° fase? ");
        int.TryParse(Console.ReadLine(), out moedas4);
        Console.Write("Quantas moedas foram coletadas na 5° fase? ");
        int.TryParse(Console.ReadLine(), out moedas5);

        moedasTotal = moedas1 + moedas2 + moedas3 + moedas4 + moedas5;

        Console.WriteLine($"A quantidade total de moedas coletadas é de: {moedasTotal}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}