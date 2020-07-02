using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNeira
{
    public class Arbitro : Persona
    {
        public double experience;
        public int energy;
        public Arbitro(string nam, int ag, string nat, int mon, double exp, int e)
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.experience = exp;
            this.energy = e;
        }
        public void foul(Jugador J, int u)
        {
            J.card += u;
            if (u==1)
            {
                Console.WriteLine("Its a yellow card!");
            }
            else if (u == 2)
            {
                Console.WriteLine("Its a red card!" +J.name +" kicked from field!");
                //-lista
            }
        }
    }
   
}
