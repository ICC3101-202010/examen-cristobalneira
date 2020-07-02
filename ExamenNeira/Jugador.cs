using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNeira
{
    public class Jugador : Persona
    {
        public int attk;
        public int deff;
        public int number;
        public string position;
        public int star;
        public int energy;
        public bool isgoalkeeper;
        public bool injured;
        public int card = 0;

        public Jugador(string nam, int ag, string nat, int mon,  int a, int d,int num, int s, int e,bool isg, bool inj) : base()
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.attk = a;
            this.deff = d;
            this.number = num;
            this.star = s;
            this.energy = e;
            this.isgoalkeeper = isg;
            this.injured = inj;

            if (attk >= 70)
            {
                position = "foward";
            }
            else if (attk>=50 && deff > 50)
            {
                position = "midfield";
            }
            else
            {
                position = "defense";
            }
            if (isgoalkeeper == true)
            {
                position = "goalkeeper";
            }
        }
    }
}
