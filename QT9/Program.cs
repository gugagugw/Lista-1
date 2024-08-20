/*-------------------------------------------------------------------
Atividade 9: Comparação de Poder de Ataque
• Contextualização: Em um jogo de luta, cada personagem tem um valor de ataque baseado em
  sua força, arma e bônus de habilidades. O total de ataque é afetado por modificadores críticos
  e pelo tipo da arma.
• Crie um programa que receba o valor da força do personagem, o poder da arma, o bônus de
  Comando: habilidades, um modificador de crítico, e um modificador para o tipo da arma. O
  programa deve calcular o total de ataque do personagem

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        double forca, poderArma, bonusHab, multCrit, multArma, totalAtk;

        System.Console.WriteLine("Quanto de força?");
        double.TryParse(Console.ReadLine(), out forca);
        System.Console.WriteLine("Quanto de poder de arma?");
        double.TryParse(Console.ReadLine(), out poderArma);
        System.Console.WriteLine("Quanto de bônus de habilidade?");
        double.TryParse(Console.ReadLine(), out bonusHab);
        System.Console.WriteLine("Quanto de modificador de crítico?");
        double.TryParse(Console.ReadLine(), out multCrit);
        System.Console.WriteLine("Quanto de modificador do tipo da arma?");
        double.TryParse(Console.ReadLine(), out multArma);

        totalAtk = forca + poderArma * (bonusHab * multCrit * multArma);

        System.Console.WriteLine($"O total de ataque é de: {totalAtk}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}