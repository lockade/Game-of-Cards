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
                Console.WriteLine("Partida numero {0}", partidas);
                partidas++;
                Carta vencedora;
                vencedora = Regras.duelo(carta1, carta2, modo1, modo2);
                if (vencedora == carta1)
                {
                    Console.WriteLine($"Jogador Venceu: {player1.nome} Carta: {vencedora.nome} \n");
                    player1.cartasMao.Add(vencedora); player1.cartasMao.Add(carta2);
                }
                else
                {
                    Console.WriteLine($"Jogador Venceu: {player2.nome} Carta: {vencedora.nome} \n");
                    player2.cartasMao.Add(vencedora); player2.cartasMao.Add(carta1);
                }
               


            } while (true);
            
            
            
        
            


        }
    
    }
    
}
