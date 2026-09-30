
using System;

namespace Skogsaventyret
{
    // Klass som beskriver spelaren
    public class Spelare
    {
        // Spelarens namn
        public string Namn { get; private set; }

        // Spelarens HP
        public int Hp { get; set; }

        // Spelarens maximala HP
        public int MaxHp { get; private set; }

        // Spelarens attack
        public int Attack { get; private set; }

        // Spelarens level
        public int Level { get; private set; }

        // Spelarens XP
        public int Xp { get; private set; }

        // Skapar en ny spelare
        public Spelare(string namn)
        {
            Namn = namn;
            MaxHp = 100;
            Hp = MaxHp;
            Attack = 20;
            Level = 1;
            Xp = 0;
        }

        // Spelaren får XP
        public void FåXp(int xp)
        {
            Xp += xp;
        }

        // Spelaren återfår HP
        public void Hela(int mängd)
        {
            Hp += mängd;

            // HP får inte bli högre än MaxHp
            if (Hp > MaxHp)
            {
                Hp = MaxHp;
            }
        }

        // Körs när spelaren överlever en dag
        public void ÖverlevDag()
        {
            Console.WriteLine($"{Namn} överlevde dagen.");
        }
    }
}