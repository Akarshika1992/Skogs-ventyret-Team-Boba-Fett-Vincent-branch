namespace Skogsaventyret
{
    // Klass som hanterar information om monstret
    public class Monster
    {
        // Monstrets namn
        public string Namn { get; private set; }

        // Monstrets HP
        public int Hp { get; set; }

        // Monstrets attack
        public int Attack { get; private set; }

        // Monstrets försvar
        public int Forsvar { get; private set; }

        // XP som spelaren får när monstret besegras
        public int XpBelöning { get; private set; }

        // Beskrivning av monstret
        public string Beskrivning { get; private set; }

        // Skapar ett nytt monster
        public Monster(
            string namn,
            int hp,
            int attack,
            int forsvar,
            int xpBelöning,
            string beskrivning)
        {
            Namn = namn;
            Hp = hp;
            Attack = attack;
            Forsvar = forsvar;
            XpBelöning = xpBelöning;
            Beskrivning = beskrivning;
        }
    }
}