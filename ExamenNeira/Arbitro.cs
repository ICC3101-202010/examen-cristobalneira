using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNeira
{
    public class Arbitro : Persona
    {
        public double experience;
        public Arbitro(string nam, int ag, string nat, int mon, double exp)
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.experience = exp;
        }
    }
   
}
