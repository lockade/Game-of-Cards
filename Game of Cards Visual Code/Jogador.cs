using System;
using System.Collections.Generic;
using System.Text;


namespace Game_of_Cards
{
    class Jogador
    {
        public string nome { get; set; }
        public int jogosVencidos { get; set; }
        public List<Carta> cartasMao = new List<Carta>();
        public static Baralho baralho = new Baralho();//static para evitar duplicidade de cartas no game!

        //Construtor
        public Jogador(string n)
        {
            this.nome = n;
            distribuirCartas();
        }

        public void distribuirCartas()
        {
            
            // Gerar Cartas
            //Distribui Cartas entre os 2 jogadores
            Random n = new Random();            
            for (int i = 0; i < 10; i++)
            {
                int indice = n.Next(baralho.allCards.Count);
                
                this.cartasMao.Add(baralho.allCards[indice]);
                
                baralho.allCards.RemoveAt(indice);
            }
            
            
            /*
            Console.WriteLine("Player 1");
            foreach(Carta x in player1.cartasMao){
                if(x is Espada)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", x.nome, "Espada", x.ataque, x.defesa, x.magia, x.resistencia);
                
                else if(x is Machado)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", x.nome, "Machado", x.ataque, x.defesa, x.magia, x.resistencia);

                else if(x is Lanca)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", x.nome, "Lanca", x.ataque, x.defesa, x.magia, x.resistencia);
            }
            Console.WriteLine("Player 2");

            foreach(Carta x in player2.cartasMao){
                if(x is Espada)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", x.nome, "Espada", x.ataque, x.defesa, x.magia, x.resistencia);
                
                else if(x is Machado)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", x.nome, "Machado", x.ataque, x.defesa, x.magia, x.resistencia);

                else if(x is Lanca)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", x.nome, "Lanca", x.ataque, x.defesa, x.magia, x.resistencia);
            }

            
            //Teste para verificar todas cartas
            foreach(Carta n in allCards){
                if(n is Espada)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", n.nome, "Espada", n.ataque, n.defesa, n.magia, n.resistencia);
                
                else if(n is Machado)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", n.nome, "Machado", n.ataque, n.defesa, n.magia, n.resistencia);

                else if(n is Lanca)
                    Console.WriteLine("Nome:{0} Tipo:{1} Ataque:{2} Defesa:{3} Magia{4} Resistencia:{5}", n.nome, "Lanca", n.ataque, n.defesa, n.magia, n.resistencia);

            }*/
            
        }

    }
}
