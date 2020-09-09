using System;
namespace BrunosAdventureTextGame
{
    public class Horse
    {
        public int Bite(int bite = 10, int lifes)
        {
            Console.WriteLine("Biteeeeee");
            return lifes - bite
        }

        public int Kick(int kick = 10, int lifes)
        {
            Console.WriteLine("Kick in the Head");
            return lifes - kick
        };
    }
}
