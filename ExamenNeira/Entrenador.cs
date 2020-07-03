using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenNeira
{
    public class Entrenador : Persona
    {
        public double tactics;
        public Entrenador(string nam, int ag, string nat, int mon,double tact)
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.tactics = tact;
        }
        public void OnPlayerChanged(object source, EventArgs e)
        {
            Console.WriteLine(name+": Changing player..");
        }
    }
}
