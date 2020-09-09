using System;
namespace BrunosAdventureTextGame
{
    public class Dragoon
        
    {
        public int scores = 100;
        public int lifes = 3;

        public static int FireOut(int burn = 10, int score)
    {
        Console.WriteLine("FIREEEEEEEE");
        return score - burn;
    }

    public static int Kick(int kick = 10, int score)
    {
        Console.WriteLine("BIG KICK");
        return score - kick;
    }


    }
}
