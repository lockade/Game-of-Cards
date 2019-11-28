using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Cards
{
    static class Regras
    {
        static public Carta duelo(Carta a, Carta b, int modoA, int modoB) //MODO FISICO = 0     MODO MAGICO = 1
        {

            int resulA, resulB;

            if (modoA == 0)
            {
                resulA = a.modoFisico(b);
            }
            else
            {
                resulA = a.modoMagico(b);
            }

            if (modoB == 0)
            {
                resulB = b.modoFisico(a);
            }
            else
            {
                resulB = b.modoMagico(a);
            }


            if (resulA == resulB)
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

            else if (resulA > resulB)
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
    }
}





