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

