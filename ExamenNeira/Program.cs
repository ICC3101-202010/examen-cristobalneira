using System;
using System.Collections.Generic;

namespace ExamenNeira
{
    class Program
    {
        static void Main(string[] args)
        {
            string c = "chile";
            Jugador j1 = new Jugador("CrisD", 21, c, 50, 100, 10, 23, false, false, 100);
            Jugador j2 = new Jugador("TomD", 21, c, 50, 100, 10, 23, false, false, 100);
            Jugador j3 = new Jugador("SebaD", 21, c, 50, 100, 10, 23, false, false, 100);

            Jugador j4 = new Jugador("CrisM", 21, c, 50, 70, 70, 23, false, false, 100);
            Jugador j5 = new Jugador("TomM", 21, c, 50, 70, 70, 23, false, false, 100);
            Jugador j6 = new Jugador("SebaM", 21, c, 50, 70, 70, 23, false, false, 100);
            Jugador j7 = new Jugador("CrisM2", 21, c, 50, 70, 70, 23, false, false, 100);
            Jugador j8 = new Jugador("TomM2", 21, c, 50, 70, 70, 23, false, false, 100);

            Jugador j9 = new Jugador("SebaD", 21, c, 50, 33, 90, 23, false, false, 100);
            Jugador j10 = new Jugador("CrisD", 21, c, 50, 33, 90, 23, false, false, 100);
            Jugador j11 = new Jugador("TomD", 21, c, 50, 33, 90, 23, false, false, 100);

            Jugador j12 = new Jugador("SebaARQ", 21, c, 50, 100, 100, 23, true, false, 100);

            Jugador j13 = new Jugador("CrisARQ", 21, c, 50, 100, 10, 23, true, false, 100);
            Jugador j14 = new Jugador("TomD2", 21, c, 50, 100, 10, 23, false, false, 100);
            Jugador j15 = new Jugador("SebaM2", 21, c, 50, 70, 70, 23, false, false, 100);

            Entrenador e1 = new Entrenador("Marcelo Bielsa", 60, "argentina", 10000, 10);
            Entrenador e2 = new Entrenador("Zenedine Zidane", 60, "francia", 10000, 10);
            Medico m1 = new Medico("Diego", 66, "chile", 1, 5.0);
            Medico m2 = new Medico("Diegodos", 66, "chile", 1, 5.0);
            Arbitro refery = new Arbitro("Pelao", 55, "chile", 3,3);
            List<Jugador> jugadores = new List<Jugador>();

            jugadores.Add(j1);
            jugadores.Add(j2);
            jugadores.Add(j3);
            jugadores.Add(j4);
            jugadores.Add(j5);
            jugadores.Add(j6);
            jugadores.Add(j7);
            jugadores.Add(j8);
            jugadores.Add(j9);
            jugadores.Add(j10);
            jugadores.Add(j11);
            jugadores.Add(j12);
            jugadores.Add(j13);
            jugadores.Add(j14);
            jugadores.Add(j15);
            
           
            Equipo eq1 = new Equipo("ChileChile", "Chile", e1, jugadores, m1);
            jugadores.Add(j15);
            Equipo eq2 = new Equipo("ChilePueblo", "Chile", e2, jugadores, m2);
            Partido p1 = new Partido(eq1, eq2, refery);
            eq1.PlayerChanged += p1.OnPlayerChanged;
            eq2.PlayerChanged += p1.OnPlayerChanged;
            p1.simulate();
            eq1.info();
            eq2.info();

        }
    }
}
