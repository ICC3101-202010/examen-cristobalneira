using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNeira
{
    public class Medico : Persona
    {
        public double experience;
        public int energy;
        public Medico(string nam, int ag, string nat, int mon, double exp, int e)
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.experience=exp;
            this.energy=e;
        }
        public void cure(Jugador J)
        {

        }
    }
}
