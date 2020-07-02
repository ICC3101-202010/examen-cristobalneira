using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNeira
{
    public class Entrenador : Persona
    {
        public double tactics;
        public double yell;

        public Entrenador(string nam, int ag, string nat, int mon,double tact, double yel)
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.tactics = tact;
            this.yell = yel;
        }
        public void changeplayer(Jugador J)
        {
            //change list orden by star
        }
    }
}
