using System;

namespace BrunosAdventureTextGame
{
    class Program
    {
        static void Main(string[] args)
        {
            

            bool quit = false;
            do
            {
                
                int score = 100;
                
                
                Console.WriteLine("Welcome to The Our Adventure Text Game !");
                Console.WriteLine("Get Ready !!!");

                Console.WriteLine("First of all, you need to choose your character !");
                Console.WriteLine("Choose (D) for - Dragon ");
                Console.WriteLine("Choose (H) for - Horse ");
                Console.WriteLine("Or Choose (Q) for quit ! ");
                var answerCharc = (Console.ReadLine()).ToLower();

                if (answerCharc == "d")
                {
                    Console.WriteLine("OK, You choosen be a Dragon, seen be stronger");
                    Console.WriteLine("So you now I'll be a Horse and we'll fight! ");
                    Console.WriteLine("Get Ready");
                    Console.WriteLine($"Now you have {score} points.");
                    Console.WriteLine("==-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--==");
                    Console.WriteLine("Choose you moove (B) for fire or (K) for kick");
                    var answerMove = (Console.ReadLine()).ToLower();
                   
                    if (answerMove == "b")
                        

                    {
                        
                        Dragoon.FireOut(10, 100);
                        Console.WriteLine("Good Shot!");
                        Console.WriteLine($"Score: {score}");

                    }

                    else if (answerMove == "k")
                    {
                        Dragoon.Kick(10, 100);
                        Console.WriteLine("Kick it !!!");
                        Console.WriteLine($"Score: {score}");
                    }

                    else





                    
                }

                else if (answerCharc == "h")
                {
                    Console.WriteLine("OK, You choose be a Horse, seen be stronger");
                    Console.WriteLine("So you now I'll be a Dragoon and we'll fight! ");
                    Console.WriteLine("Get Ready");
                    Console.WriteLine($"Now you have {lifes} and to start you have {score} points.");
                    quit = true;
                }

                else if (answerCharc != "d" && answerCharc != "h" && answerCharc != "q")
                {
                    Console.WriteLine("Invalid Answer");
                    quit = true;
                }

                else if (answerCharc == "q")
                {
                    Console.WriteLine("Looser !!!!!");
                    Console.WriteLine("When you become stronger come back !!");
                    quit = true;
                }
            } while (quit == false);
            
        }
    }
}
