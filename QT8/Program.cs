/*-------------------------------------------------------------------
Questão 8: Cálculo de Pontos de Habilidade
• Contextualização: Ao subir de nível, um jogador recebe pontos de habilidade que podem ser
  distribuídos entre força, agilidade, inteligência e dois atributos adicionais.
• Comando: Desenvolva um programa que receba a quantidade de pontos de habilidade
  atribuídos a cada uma das cinco características e calcule o total de pontos distribuídos.


@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.Arm;
class Program {
    static void Main(string[] args) {
        int forca, agi, inte, des, vit, atributosTotal;

        System.Console.WriteLine("Quantos pontos de força? ");
        int.TryParse(Console.ReadLine(), out forca);
        System.Console.WriteLine("Quantos pontos de agilidade? ");
        int.TryParse(Console.ReadLine(), out agi);
        System.Console.WriteLine("Quantos pontos de destreza? ");
        int.TryParse(Console.ReadLine(), out des);
        System.Console.WriteLine("Quantos pontos de vitalidade? ");
        int.TryParse(Console.ReadLine(), out vit);
        System.Console.WriteLine("Quantos pontos de inteligência? ");
        int.TryParse(Console.ReadLine(), out inte);

        atributosTotal = forca + agi + des + vit + inte;

        System.Console.WriteLine($"O total de pontos é de: {atributosTotal}");
        

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}