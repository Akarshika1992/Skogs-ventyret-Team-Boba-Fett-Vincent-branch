using System;
namespace Skogsaventyret
{

    // Public class Game som interagerar med resten av projektet.

    public class Game
    {
        // Lista med platser i Göteborg som ska slumpas fram varje gång spelaren är ute på äventyr.
        private static string[] Platser =
        {
            "Du strosar runt i Majorna",
            "Du tar en promenad i Tingstadsvass",
            "Du beundrar landskapet i Partille",
            "Du promenerar på Linnégatan",
            "Du vandrar genom Nordstan",
            "Du promenerar genom Biskopsgården"
        };

        //Slumpgenerator som används för att generera en slumpmässig plats och slumpmässiga "monster".
        private Random slumpgenerator = new Random();

        //fältdeklarationer
        private Spelare spelare;
        private bool spelPågår; // Håller koll på om spelet fortfarande pågår.
        private int dag;        // Vilken dag i spelet vi är på.

        // Sätter upp startläget innan spelet börjar.
        public Game()
        {
            dag = 1;
            spelPågår = true;
        }

        // Startar spelet. Frågar efter spelarens namn och kör sedan
        // spelloopen (en dag i taget) tills spelPågår blir false.
        public void Starta()
        {
            Console.WriteLine("Hallå eller! Välkommen till GBG.");
            Console.Write("Vad heter du?:");
            string namn = Console.ReadLine();

            spelare = new Spelare(namn);

            while (spelPågår)
            {
                Promenad();
            }

            Console.WriteLine("Game Over gubben. Bättre lycka nästa gång.");
        }
