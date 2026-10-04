using System;

namespace Skogsaventyret
{
    public static class Monsterfabrik
    {
        // Slumpgenerator
        private static Random slumpgenerator = new Random();

        // Skapar ett slumpmässigt monster
        public static Monster SkapaSlumpatMonster()
        {
            // Olika monster som kan dyka upp
            Monster[] monster =
            {
                new Monster(
                    "Fyllegubbe",
                    50,
                    10,
                    3,
                    20,
                    "En full gubbe vinglar fram mot dig."
                ),

                new Monster(
                    "Poseidon",
                    100,
                    20,
                    8,
                    50,
                    "Poseidon dyker upp och är inte särskilt nöjd."
                ),

                new Monster(
                    "Nordstans Michael Jackson",
                    75,
                    15,
                    5,
                    35,
                    "En mystisk Michael Jackson dyker upp från Nordstan."
                )
            };

            // Slumpa ett monster från listan
            int index = slumpgenerator.Next(monster.Length);

            return monster[index];
        }
    }
}