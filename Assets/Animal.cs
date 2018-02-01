using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{

    public bool Key;
    public int Health = 3;
    public bool BossKey;
	
//My understanding of if statement vs else clause is that they work together to give two possibilities. If its true the program says/does this
//if its not true then the program says/does that. I understand as well that an else clause is not necessary, if you leave on out it does nothing
//on Zelda, once you have a key you just walk up to the door and the lock falls off, otherwise the door doesnt open and its pretty apparent that
//you you need a key to enter. That is an example when an else clause really isnt necessary. Else clauses can do many things, if you have a game
//that is a character builder, (like fallout) you have questions that are like, "If you were approached by a peasant, would you donate a coin or 
//ignore them, you could use the if and else to add or decrease from your charisma or even your coins as well.
//Overall there is so much you can do with just this simeple programing knowledge already.
    void Start()
    {

        if (Key)
        {
            print("I have the Key.");
        }
        else
        {
            print("You cannot pass without the Key");
        }

        if (Health > 0)
        {
            print("Still Alive.");
        }
        else
        {
            print("RIP!");
        }

        if (Name == "Link")
        {
            print("Yes, his names Link.");
        }

        else
        {
            print("Wrong, Link is his name.");
        }

        if (BossKey)
        {
            print("Prepare for battle!");
        }

        else
        {
            print("The Boss Key is necessary to enter.");
        }
		if (HeartMeter > 3)
		{
			print(Name + " is full on health.");
		}
		else
		{
			print(Name + " is low on food.");
		}
    }



    public string Name;
    public int HeartMeter;
  
}

