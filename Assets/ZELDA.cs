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
    void Start() {
        if(HeartMeter > 0 && HeartMeter == 3)
        {
            print("You are full health.");
        }
        if(Health < 3 && Health > 0)
        {
            print("You are low on health, restore soon.");
        }
        if(BossKey && Health > 2)
        {
            print("You are ready for batttle.");
        }
        if(Password == "Hyrule" || Password == "hyrule" || Password == "HYRULE");
        {
            print("You may enter!");
        }

    }
}

