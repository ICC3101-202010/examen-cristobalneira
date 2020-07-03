using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ExamenNeira
{
    public class Equipo
    {
        public string name;
        public string country;
        public bool itsnational = true;
        public Entrenador dt;
        public List<Jugador> players;
        public Medico medic;
        public Equipo(string n, string countr,Entrenador d, List<Jugador> p, Medico m)
        {
            this.dt = d;
            this.players = p;
            this.medic = m;
            this.name = n;
            this.country = countr;
            foreach (var item in players)
            {
                if(country.ToLower() != item.nation.ToLower())
                {
                    itsnational = false;
                }
            }
            int cw = 0;
            foreach (var item in players)
            {
                if (item.isgoalkeeper == true)
                {
                    cw += 1;
                }
            }
            if (cw < 1)
            {
                players[16].isgoalkeeper = true;
                players[16].position = "goalkeeper";

            }

            while (players.Count() >= 16)
            {
                Console.WriteLine("To many players, eliminating last player of the list of {0} team,  until reaches 15...",name);
                players.RemoveAt(players.Count - 1);
                Thread.Sleep(2000);
            }

        }
        //Delegate
        public delegate void PlayerChangedEventHandler(object source, EventArgs args);

        //Event
        public event PlayerChangedEventHandler PlayerChanged;

        //RaisePublishevent
        protected virtual void OnPlayerChanged()
        {
            if (PlayerChanged != null)
            {
                PlayerChanged(this, EventArgs.Empty);
            }
        }
        public void change(Jugador J)
        {
            J.injured = true;
            bool cambio=medic.Evaluar(J);
            Console.WriteLine("Player {0} yells: ARGS I need a change!",J.name);
            if (cambio == true)
            {
                OnPlayerChanged();
                if (dt.tactics == 10)
                {
                    Console.WriteLine("DT: {0}, changing {1}", dt.name, J.name);
                    Console.WriteLine(J.name + " its injured!");
                    Thread.Sleep(4000);
                }
            }
            else
            {
                if (dt.tactics == 10)
                {
                    Console.WriteLine("DT: {0}, yells to {1}: GO BACK AND PLAY COME ON!", dt.name, J.name);
                    Console.WriteLine(J.name + " its not injured!");

                }
                else { }
                Thread.Sleep(4000);
            }
        }
        public void info()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Team: {0}, Country: {1}, DT: {2}",name,country,dt.name);
            Console.WriteLine("Players: ");
            foreach (var item in players)
            {
                item.info();
            }
            Thread.Sleep(2000);
        }
    }
}
