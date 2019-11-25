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

            if(modoB == 0)
            {
                resulB = b.modoFisico(a);
            }
            else
            {
                resulB = b.modoMagico(a);
            }

            
            if (resulA == resulB)
            {

                if(a is Espada)
                {
                    if(b is Machado)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                }else if(a is Machado)
                {
                    if(b is Lanca)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                }else if(a is Lanca)
                {
                    if(b is Espada)
                    {
                        return a;
                    }
                    else
                    {
                        return b;
                    }
                }
            }

            return a;//bug
        }
    }
}
