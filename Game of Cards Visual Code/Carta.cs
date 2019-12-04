using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Cards
{
    abstract public class Carta
    {
        public string nome { get; set; }
        public int ataque { get; set; }
        public int defesa { get; set; }
        public int magia { get; set; }
        public int resistencia { get; set; } 
        public int pontuacaoTemp { get; set;}

        public Carta(string n, int a, int d, int m, int r)
        {
            this.nome = n;
            this.ataque = a;
            this.defesa = d;
            this.magia = m;
            this.resistencia = r;
        }


        public int modoFisico(Carta adversario)
        {
            return this.ataque - adversario.defesa;
        }

        public int modoMagico(Carta adversario)
        {
            return this.magia - adversario.resistencia;
        }

        public static string retornaTipo(Carta a){
            if(a is Espada)
                return "Espada";
            else if(a is Machado)
                return "Machado";
            else
                return "Lança";
        }

    }

    public class Espada : Carta
    {
        public Espada(string n, int a, int d, int m, int r) : base(n ,a,d,m,r)
        {
            //Construtor
        }
    }

    public class Lanca : Carta
    {
        public Lanca(string n, int a, int d, int m, int r) : base(n, a, d, m, r)
        {
            //Construtor
        }
    }

    public class Machado : Carta
    {
        public Machado(string n, int a, int d, int m, int r) : base(n, a, d, m, r)
        {
            //Construtor
        }
    }
}
