using System;
using System.Collections.Generic;
using System.Text;

namespace Game_of_Cards
{
    public class Baralho{
        public List<Carta> allCards = new List<Carta>();
        public Baralho(){//Construtor
            // Gerar Cartas
            this.allCards.Add(new Espada("Alondeg", 9, 4, 5, 1));
            this.allCards.Add(new Espada("Amatsu", 7, 3, 5, 4));
            this.allCards.Add(new Espada("Belmarg", 5, 2, 5, 3));
            this.allCards.Add(new Espada("Kaducho", 5, 4, 5, 3));
            this.allCards.Add(new Espada("Rapison", 5, 2, 6, 2));
            this.allCards.Add(new Espada("Scimaut", 7, 1, 7, 3));
            this.allCards.Add(new Espada("Venoma", 5, 1, 9, 4));
            this.allCards.Add(new Lanca("Crasher", 8, 4, 6, 2));
            this.allCards.Add(new Lanca("Hoenigo", 6, 3, 6, 3));
            this.allCards.Add(new Lanca("Ketsu", 5, 2, 7, 3));
            this.allCards.Add(new Lanca("Nepma", 5, 1, 8, 4));
            this.allCards.Add(new Lanca("Pioptu", 6, 2, 5, 2));
            this.allCards.Add(new Lanca("Setka", 7, 3, 6, 3));
            this.allCards.Add(new Lanca("Tunigola", 9, 4, 5, 4));
            this.allCards.Add(new Machado("Capie", 8, 3, 6, 3));
            this.allCards.Add(new Machado("Duotsu", 5, 2, 6, 4));
            this.allCards.Add(new Machado("Evinoa", 6, 4, 7, 2));
            this.allCards.Add(new Machado("Fermita", 7, 4, 6, 1));
            this.allCards.Add(new Machado("Gotsau", 9, 3, 5, 3));
            this.allCards.Add(new Machado("Qiudeb", 5, 2, 9, 4));
        }

        
    }
}




