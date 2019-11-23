using System;

namespace Game_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Espada carta1 = new Espada("Alondeg", 9, 4, 5, 1);
            Lanca carta2 = new Lanca("Tunigola", 9, 4, 5, 4);


            Console.WriteLine(Regras.duelo(carta1, carta2, 0, 0).nome);

            //Console.WriteLine(carta1.nome);
            Console.ReadLine();
        }
    }
}
