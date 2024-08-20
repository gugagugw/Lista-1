/*-------------------------------------------------------------------
Questão 1: Informações do Personagem
• Contextualização: Em um jogo de RPG, o jogador precisa inserir as informações básicas do
  personagem antes de começar a aventura.
• Comando: Crie um programa que receba o nome, idade, nível inicial, classe, e raça do
  personagem e exiba esses dados no console.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        string? nome, classe, raca;
        int idade, nivel;

        Console.WriteLine("Nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Idade: ");
        int.TryParse(Console.ReadLine(), out idade);
        Console.WriteLine("Nível Inicial: ");
        int.TryParse(Console.ReadLine(),out nivel);
        Console.WriteLine("Classe: ");
        classe = Console.ReadLine();
        Console.WriteLine("Raça: ");
        raca = Console.ReadLine();

        Console.WriteLine($"\nO nome do personagem é: {nome}");
        Console.WriteLine($"A idade do personagem é: {idade}");
        Console.WriteLine($"O nível inicial é : {nivel}");
        Console.WriteLine($"A classe é: {classe}");
        Console.WriteLine($"A raça é: {raca}");

        Console.WriteLine("\nPressione ENTER para fechar");
        Console.ReadLine();
    }
}