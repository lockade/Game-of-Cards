using System;
using System.IO;
namespace Game_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***** BEM-VINDO AO GAME OF CARDS 1.0 ********");
            Console.WriteLine("\n \n \n Digite o nome do primeiro jogador");
            Console.Write(">>");
            Jogador player1 = new Jogador();
       
           
            Console.Clear();

            Console.WriteLine("***** BEM-VINDO AO GAME OF CARDS 1.0 ********");
            Console.WriteLine("\n \n \n Digite o nome do segundo jogador");
            Console.Write(">>");
            Jogador player2 = new Jogador();           
      

            Console.Clear();


          
            Random a = new Random();         
            int jogada = a.Next(0, 2);

            

            Carta carta1, carta2;
            int modo1,modo2;
            int partidas = 0;
            do {
               
               if(jogada == 0)
                {
                    carta1 = Regras.selecionarCarta(player1);
                    modo1 = Regras.selecionaModo(player1);                   
                    carta2 = Regras.selecionarCarta(player2);
                    modo2 = Regras.selecionaModo(player2);
              
                }
                else {

                    carta2 = Regras.selecionarCarta(player2);
                    modo2 = Regras.selecionaModo(player2);             
                    carta1 = Regras.selecionarCarta(player1);
                    modo1 = Regras.selecionaModo(player1);

                }
                Console.WriteLine($"Jogador {player1.nome} está com {player1.qntCartasMao()} cartas !");
                Console.WriteLine($"Jogador {player2.nome} está com {player1.qntCartasMao()} cartas !");// tá bugado
                partidas++;
                Carta vencedora;
                vencedora = Regras.duelo(carta1, carta2, modo1, modo2);

                Console.WriteLine($"Player {player1.nome} Selecionou a Carta: {carta1.nome} | Tipo: {Carta.retornaTipo(carta1)} | Ataque:{carta1.ataque} | Defesa:{carta1.defesa} | Magia:{carta1.magia} | Resistencia:{carta1.resistencia}");
                Console.WriteLine($"Player {player2.nome} Selecionou a Carta: {carta2.nome} | Tipo: {Carta.retornaTipo(carta2)} | Ataque:{carta2.ataque} | Defesa:{carta2.defesa} | Magia:{carta2.magia} | Resistencia:{carta2.resistencia}");
                
                Console.WriteLine($"***** Pontuação *****\n Player: {player1.nome} Carta: {carta1.nome} | Pontuação: {carta1.pontuacaoTemp}\n Player: {player2.nome} Carta: {carta2.nome} | Pontuação: {carta2.pontuacaoTemp}");
                
                Console.WriteLine("Partida numero {0}", partidas);
                
                if (vencedora == carta1)
                {
                    Console.WriteLine($"Jogador Venceu: {player1.nome} Carta: {vencedora.nome} | Tipo: {Carta.retornaTipo(vencedora)} | Ataque:{vencedora.ataque} | Defesa:{vencedora.defesa} | Magia:{vencedora.magia} | Resistencia:{vencedora.resistencia}");
                    player1.cartasMao.Add(vencedora); player1.cartasMao.Add(carta2);
                }
                else
                {
                    Console.WriteLine($"Jogador Venceu: {player2.nome} Carta: {vencedora.nome} | Tipo: {Carta.retornaTipo(vencedora)} | Ataque:{vencedora.ataque} | Defesa:{vencedora.defesa} | Magia:{vencedora.magia} | Resistencia:{vencedora.resistencia}");
                    player2.cartasMao.Add(vencedora); player2.cartasMao.Add(carta1);
                }
               


            } while (Regras.continuarPartida(player1, player2));
            
            
            
        
            


        }
    
    }
    
}
