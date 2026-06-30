using System;
using System.Collections;
using RpChallenge;



class GameRunning()
{
    
    public static void GameRun()
    {
        Console.Clear();
        CoreFeatures.Start();

        while (CoreFeatures.PlayerHealth(0) > 0 && CoreFeatures.MonsterHealth(0)  > 0)
        {
            int attackDmg = CoreFeatures.AttackDmg();

            Console.WriteLine($"\nYou have attacked the monster, you hit him with {attackDmg} damage!");
            CoreFeatures.MonsterHealth(attackDmg);
            Console.WriteLine($"\nPlayer health: {CoreFeatures.PlayerHealth(0)}\tMonsterHealth: {CoreFeatures.MonsterHealth(0)}");

            Console.WriteLine("\n\nPress any key to continue");
            Console.ReadKey();

            if (CoreFeatures.MonsterHealth(0)  > 0)
            {

                attackDmg = CoreFeatures.AttackDmg();

                Console.WriteLine($"\nThe monster hit you with {attackDmg} damage!");
                CoreFeatures.PlayerHealth(attackDmg);  
                Console.WriteLine($"\nPlayer health: {CoreFeatures.PlayerHealth(0)}\tMonsterHealth: {CoreFeatures.MonsterHealth(0)}");

                Console.WriteLine("\n\nPress any key to continue");
                Console.ReadKey();
            }

        }

        Console.WriteLine(CoreFeatures.EndGameMsg(CoreFeatures.PlayerHealth(0), CoreFeatures.MonsterHealth(0)));

        PlayAgain();

        
    }

    public static void PlayAgain()
    {
        Console.WriteLine("\n\nPress 1 to play again ('x' to exit)");

        

        while (true)
        {
            ConsoleKeyInfo input = Console.ReadKey(true); 
            switch (input.KeyChar)
            {
                case '1': GameRun(); break;
                case 'x': Program.Start(); break;
                default: Console.WriteLine("Invalid Input, try again"); break;
            }

        }
    }


    
    
}