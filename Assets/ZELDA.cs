using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZELDA : MonoBehaviour {
    public bool Key;
    public int Health = 3;
    public bool BossKey;
    public string Name;
    public int HeartMeter;
    public string Password = "Hyrule";
    public int Potion;
    public int Damage;
    //My understanding of Math Operators is pretty solid. Its just like math. You use () to split up what you are calculating. I used 
    //examples showing all kinds of different scenarios and options. You can use +, -, /, *, and even % to show intergers. I am honestly
    //unsure of why you would want to show intergers but im sure theres a reason its in here. Its just like, you have this much life,
    //you took this much damage, now you have this much life left. Simple as that.
    void Start() {
    if((HeartMeter) - (Damage) < 0)
    {
        print("You are Dead");
    }
        else
        {
        print("You're still alive");
    }
    if((Health) + (Potion) > 3)
    {
        print("You are full on health");
    }
    if(1 + 1 == 2)
    {
        print("yes, the answer is 2");
    }
    if(6 * 2 == 12)
    {
        print("Yep");
    }
    if(9 / 3 != 4)
    {
        print("The answer isnt 4");
    }
    if(16 % 5 == 1)
    {
        print("The interger is 1");
    }
    if((1 + 1) * (1 + 1) == 4)
    {
        print("Oh yeahhhhh");
    }
    if((2 * 2) - 1 == 3)
    {
        print("mmmhhhhh");
    }
    if(1 / 1 != 2)
    {
        print("Not that");
    }
    if(5 + 5 - 1 == 9)
    {
        print("Nice math bud");
    }
    }
}

