using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public string Name;
public int FoodCount;
void OnMouseDown()
{
	print("I have a " + Name);
	print("It has this amount of food: " + FoodCount);

}

	
		
	}

