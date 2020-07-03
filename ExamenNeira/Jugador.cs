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
        public bool isgoalkeeper;
        public string position;
        public bool injured;
        public int energy;
       

        public Jugador(string nam, int ag, string nat, int mon,  int a, int d,int num,bool isg, bool inj, int e) : base()
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.attk = a;
            this.deff = d;
            this.number = num;
            this.energy = e;

            this.isgoalkeeper = isg;
            this.injured = inj;

            if (attk >= 70 && deff <= 50)
            {
                position = "foward";
            }
            else if (attk>=50 && deff >= 50)
            {
                position = "midfield";
            }
            else if (deff>=50 && attk <=50)
            {
                position = "defense";
            }
            if (isgoalkeeper == true)
            {
                position = "goalkeeper";
            }
        }
        public void info()
        {
            Console.WriteLine("Name: {0}, Position: {1}, Number: {2}",name,position,number);
        }
    }
}
