using System;
using System.Collections.Generic;
using System.Resources;
using System.Text;

namespace ExamenNeira
{
    public class Medico : Persona, ICurar
    {
        public double experience;
        public Medico(string nam, int ag, string nat, int mon, double exp)
        {
            this.name = nam;
            this.age = ag;
            this.nation = nat;
            this.money = mon;
            this.experience = exp;
        }
        public bool Evaluar(Jugador J)
        {
            Random r1 = new Random();
            int r= r1.Next(0, 10);
            if (r >= 2)
            {
                J.injured = true;
                return true;
            }
            else
            {
                Cure(J);
                Console.WriteLine(J.name+ " has been cured by medic");
                return false;
            }
        }
        public void Cure(Jugador J)
        {
            J.energy += 10;
        }
    }
}
