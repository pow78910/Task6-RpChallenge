using System;
using System.Collections;
using System.Security.Cryptography.X509Certificates;


public class CoreFeatures()
{
    
    
   public static int playerHealth, monsterHealth;

   public static void Start()
    {
        playerHealth = 10; 
        monsterHealth = 10; 
    }
     
    public static int PlayerHealth(int attackDmg)
    {
        playerHealth -= attackDmg;

        switch (playerHealth)
        {
            case <0: playerHealth = 0; 
            break;
        }
        return playerHealth;
    }
    public static int MonsterHealth(int attackDmg)
    {
        monsterHealth -= attackDmg;

        switch (monsterHealth)
        {
            case <0: monsterHealth = 0; 
            break;
        }
        return monsterHealth;
    }

    public static int AttackDmg()
    {
        Random random = new Random();

        int attackDmg = random.Next(1,11);



        return attackDmg;
    }

    public static string EndGameMsg(int playerHealth, int monsterHealth)
    {
        string msg = "";

        if (playerHealth < monsterHealth)
        {
            msg = "\nThe monster killed you, you lose";

        }
        else if (playerHealth > monsterHealth)
        {
            Console.WriteLine("\nYou killed the monster, you win");
        }
        else
        {
            msg = "error!!!";
        }

        return msg;


    }

    

}