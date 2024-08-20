/*-------------------------------------------------------------------
Questão 5: Cálculo de Distância Percorrida
• Contextualização: Um veículo no jogo percorre uma certa distância em um tempo determinado.
• Comando: Crie um programa que receba a velocidade do veículo, o tempo de viagem e dois
  multiplicadores (um para condições climáticas e outro para estado do veículo), e calcule a
  distância total percorrida.

@Lista: 01 - Lógica de Programação
@Autor: Gustavo Pereira
@Data: 20/08/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) {
        int velocidade, tempo;
        double clima, estado, distancia;

        Console.Write("Qual a velocidade?");
        int.TryParse(Console.ReadLine(), out velocidade);
        Console.Write("Qual a tempo?");
        int.TryParse(Console.ReadLine(), out tempo);
        Console.Write("Qual o clima?");
        double.TryParse(Console.ReadLine(), out clima);
        Console.Write("Qual a estado do veículo?");
        double.TryParse(Console.ReadLine(), out estado);

        distancia = velocidade * tempo * clima * estado;

        Console.WriteLine($"A distância percorrida foi de: {distancia}");

        System.Console.WriteLine("\n Pressione ENTER para fechar");
        Console.ReadLine();
    }
}