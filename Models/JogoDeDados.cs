using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogarDados.Models
{
    public class JogoDeDados
    {
        public string? Jogador1 { get; set; } = default;
        public string? Jogador2 { get; set; } = default;

        public int NumeroDeRodadas { get; set; } = 0;

        public int ContadorDeRodadas { get; set; } = 0;

        public int somaDadoJogador1 { get; set; } = 0;
        public int somaDadoJogador2 { get; set; } = 0;

        public void RolarOsDados(string nome1, string nome2, int numRodadas)
        {
            Jogador1 = nome1;
            Jogador2 = nome2;
            NumeroDeRodadas = numRodadas;


            ContadorDeRodadas += 1;
            Console.WriteLine($"\n{ContadorDeRodadas}ª RODADA:");
            Random rand = new Random();
            int valorDadoJogador1 = rand.Next(1, 6);
            int valorDadoJogador2 = rand.Next(1, 6);


            somaDadoJogador1 += valorDadoJogador1;
            somaDadoJogador2 += valorDadoJogador2;

            Console.WriteLine($"{Jogador1}\nDado:{valorDadoJogador1}");
            Console.WriteLine($"{Jogador2}\nDado:{valorDadoJogador2}");



            if (NumeroDeRodadas == ContadorDeRodadas)
            {
                if (somaDadoJogador1 == somaDadoJogador2)
                {
                    Console.WriteLine($"JOGO EMPATADO!\n Não houve vencedores.\n{Jogador1} - Pontuação Final: {somaDadoJogador1}");
                    Console.WriteLine($"\n{Jogador2} - Pontuação Final: {somaDadoJogador2}");
                }
                else if (somaDadoJogador1 > somaDadoJogador2)
                {
                    Console.WriteLine($"VENCEDOR: {Jogador1} - pontuação final: {somaDadoJogador1}\n{Jogador2} - Pontuação Final: {somaDadoJogador2}");
                }
                else
                {
                    Console.WriteLine($"VENCEDOR: {Jogador2} - pontuação final: {somaDadoJogador2}\n{Jogador1} - Pontuação Final: {somaDadoJogador1}");
                }
            }
            else
            {
                RolarOsDados(nome1, nome2, numRodadas);
            }
        }


    }


}