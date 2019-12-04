using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Cards
{
    static class Regras
    {
        static public Carta duelo(Carta a, Carta b, int modoA, int modoB) //MODO FISICO = 0     MODO MAGICO = 1
        {
            if (modoA == 0)
            {
                a.pontuacaoTemp = a.modoFisico(b);
            }
            else
            {
                a.pontuacaoTemp = a.modoMagico(b);
            }

            if (modoB == 0)
            {
                b.pontuacaoTemp = b.modoFisico(a);
            }
            else
            {
                b.pontuacaoTemp = b.modoMagico(a);
            }


            if (a.pontuacaoTemp == b.pontuacaoTemp)
            {

                if (a is Espada)
                {
                    if (b is Machado)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                }
                else if (a is Machado)
                {
                    if (b is Lanca)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                }
                else if (a is Lanca)
                {
                    if (b is Espada)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                }
            }

            else if (a.pontuacaoTemp > b.pontuacaoTemp)
            {
                return a;

            }
            else
            {
                return b;
            }
            return null;
        }
        public static Carta selecionarCarta(Jogador player)
        {
            Console.WriteLine($"O {player.nome} joga. \nPressione uma tecla para continuar. \n");
            Console.ReadKey();
            player.exibirCarta();
            Console.WriteLine("Selecione sua carta:");
            bool erro = false; int selecao = 0;
            do
            {
                try
                {
                    
                    selecao = int.Parse(Console.ReadLine());
                    if(selecao > player.cartasMao.Count) {
                        Console.WriteLine("Dado errado");
                    }
                    erro = true;
                }
                catch
                {
                    Console.WriteLine("Dado errado");
                    erro = false;

                }
            } while (!erro || player.cartasMao.Count < selecao);
            Console.Clear();
            
            Carta carta = player.cartasMao[selecao - 1];
            player.cartasMao.RemoveAt(selecao -1);
            return carta;

        }

        public static int selecionaModo(Jogador player)
        {
            Console.WriteLine("Que tipo de modo você quer?");
            Console.WriteLine("0 - Para fisico");
            Console.WriteLine("1 - Para mágico");
            
            bool erro = false; int selecao = 9;
            while (!erro && selecao > 1)
            {
                try
                {
                    
                    selecao = int.Parse(Console.ReadLine());
                    erro = true;
                }
                catch
                {
                    Console.WriteLine("Dado errado");
                    erro = false;

                }
            }
            Console.Clear();
            return selecao;
        }

        public static bool continuarPartida(Jogador player1, Jogador player2){
            if(player1.cartasMao.Count == 0){
                player2.vitorias++;
                Console.WriteLine("********************************************************\nTemos um Vencedor ! Parabéns {0} !", player2.nome);
                return false;
            }
            else if(player2.cartasMao.Count == 0){
                player1.vitorias++;
                Console.WriteLine("********************************************************\nTemos um Vencedor ! Parabéns {0} !", player1.nome);
                return false;
            }
            return true;
        }

        public static void teste(Jogador player1){
            player1.nome = "Rodolfo";
        }
    }
}





