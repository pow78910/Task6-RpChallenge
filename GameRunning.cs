using System;
using System.Collections;



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

        Console.ReadKey();

        GameRun();
    }

    
    
}