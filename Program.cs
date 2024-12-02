using JogarDados.Models;

string jogador1 = "a";
string jogador2 = "a";
int numRodadas = 0;

Console.WriteLine("Bem Vindo ao Jogo dos Dados!\nREGRAS:\nCada Jogador vai rolar o dados e ao final de todas as rodadas, aquele que tiver o maior valor vence.");
while (jogador1 == jogador2)
{
    Console.WriteLine("Informe o nome do 1° jogador:");
    jogador1 = Convert.ToString(Console.ReadLine());
    Console.WriteLine("Informe o nome do 2° jogador:");
    jogador2 = Convert.ToString(Console.ReadLine());
    if (jogador1 == jogador2)
    {
        Console.WriteLine("Os nomes dos jogadores não podem ser iguais, informe nomes diferentes:");
    }
}

Console.WriteLine("Informe o número de rodadas totais:");
numRodadas = Convert.ToInt32(Console.ReadLine());

JogoDeDados jogo = new();
jogo.RolarOsDados(jogador1, jogador2, numRodadas);





