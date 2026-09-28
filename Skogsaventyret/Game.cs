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
             "Du beundrar landskapet i Slottsskogen",
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
