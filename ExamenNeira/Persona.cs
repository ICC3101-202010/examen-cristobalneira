using System;

namespace ExamenNeira
{
    public abstract class Persona
    {
        public string name;
        public int age;
        public string nation;
        public int money;
        public virtual void infopers()
        {
            Console.WriteLine("Name: "+name +", Age: "+age+", Nation: "+nation+", MoneyPerMounth: "+money);
        }

    }
}
