using System;

namespace Game_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogador player1 = new Jogador("Jefferson");
            Jogador player2 = new Jogador("Tiago");
            Console.WriteLine("Player 1 ");
            foreach(Carta n in player1.cartasMao){
                Console.WriteLine(n.nome);
            }
            Console.WriteLine("Player 2 ");
            foreach(Carta n in player2.cartasMao){
                Console.WriteLine(n.nome);
            }
            Console.WriteLine("Tamanho do Baralho - " + Jogador.baralho.allCards.Count);

            //Console.WriteLine(carta1.nome);
            Console.ReadLine();
        }
    }
}
