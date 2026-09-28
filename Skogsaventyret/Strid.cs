
using System;

namespace Skogsaventyret
{
    // Klass som hanterar striden mellan spelaren och monstret
    public class Strid
    {
        // Spelaren och monstret som slåss
        private Spelare spelare;
        private Monster monster;

        // Används när vi behöver slumpa fram skada
        private Random slumpgenerator = new Random();

        // Tar emot spelaren och monstret när striden startar
        public Strid(Spelare spelare, Monster monster)
        {
            this.spelare = spelare;
            this.monster = monster;
        }


        //Kör själva striden
        public bool Kör()
        {

            //Fortsätter så länge bpda har HP kvar
            while (spelare.Hp > 0 && monster.Hp > 0)
            {
                Console.WriteLine("\n--- STRID ---");

                //Visar HP för båda
                Console.WriteLine(
                   $"{spelare.Namn}: {spelare.Hp}/{spelare.MaxHp} HP");



            }

        }





























    }








}