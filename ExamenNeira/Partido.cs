using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ExamenNeira
{
    public class Partido
    {
        public Equipo eq1;
        public Equipo eq2;
        public Arbitro refery;
        public int minutes;
        public bool itsnacional;
        public string goals="";
        public Partido(Equipo e1, Equipo e2, Arbitro a1)
        {
            eq1 = e1;
            eq2 = e2;
            refery = a1;
        }
        //#1
        public bool verification()
        {
            bool playable = false;
            if(eq1.itsnational==true && eq2.itsnational==true)
            {
                playable = true;
                itsnacional = true;
            }
            else if (eq1.itsnational == false && eq2.itsnational == false)
            {
                playable = true;
                itsnacional = false;
            }
            return playable;

            
        }
        public void OnPlayerChanged(object source, EventArgs e)
        {
            Console.WriteLine("Change in the match!");
        }
        //#2 if #1 returns true
        public void simulate()
        {
            
            
            if (verification() == true)
            {
                int attk1 = 0;
                int deff1 = 0;
                int attk2 = 0;
                int deff2 = 0;
                int diff1 = attk1 - deff2;
                int diff2 = attk2 - deff1;

                foreach (var item in eq1.players)
                {
                    attk1 += item.attk;
                    deff1 += item.deff;

                }
                foreach (var item in eq2.players)
                {
                    attk2 += item.attk;
                    deff2 += item.deff;

                }

                if (diff1>=5 && diff1<=10)
                {
                    goals += eq1.name + " 1-" ;
                }
                
                else if (diff1 >= 10 && diff1 <= 20)
                {
                    goals += eq1.name + " 2-";

                }
                else if (diff1 >= 5)
                {
                    goals += eq1.name + " 0-";
                }
                else
                {
                    goals+= eq1.name + " 3-";
                }
                if (diff2 >= 0 && diff2 <= 10)
                {
                    goals += "1 "+eq2.name;
                }
                else if (diff2 >= 10 && diff2 <= 20)
                {
                    goals +="2 " + eq2.name;

                }
                else if (diff2 >= 5)
                {
                    goals +="0 " + eq2.name;
                }
                else
                {
                    goals += eq1.name + "3 " + eq2.name;

                }
                foreach (var item in eq1.players)
                {
                    item.energy -= 50;
                }
                foreach (var item in eq2.players)
                {
                    item.energy -= 50;
                }
                minutes = 93;
                info();
                Random r1 = new Random();
                int r = r1.Next(1, 10);
                int r2 = r1.Next(1, 10);
                if (r >= 6)
                {
                    eq1.change(eq1.players[r]);
                    Thread.Sleep(2000);
                    eq2.change(eq2.players[r2]);
                    Thread.Sleep(2000);
                }

                Console.WriteLine("Duration: {0}", minutes);
                Console.WriteLine("Result: " + goals);
            }
            else
            {
                Console.WriteLine("No match today!");
            }
        }
        //#3 if #2 is made
        public void info() 
        {
            if (itsnacional == true)
            {
                Console.WriteLine("National Match!");
            }
            else
            {
                Console.WriteLine("League Match!");
            }
            Console.WriteLine("Todays match will play: {0} v/s {1}",eq1.name,eq2.name);
            Console.WriteLine("Refery: "+refery.name);

        }

    }
}
