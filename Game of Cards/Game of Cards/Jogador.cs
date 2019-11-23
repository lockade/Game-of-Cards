using System;
using System.Collections.Generic;
using System.Text;


namespace Game_of_Cards
{
    class Jogador
    {
        public string nome { get; set; }
        public int jogosVencidos { get; set; }
        List<Carta> cartasMao = new List<Carta>();
    }
}
