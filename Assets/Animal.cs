using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public string Name;
public int FoodCount;
public string Dogsname;
public float Math;
public string Name3;
void OnMouseDown()
{
	print("I have a " + Name);
	print("It has this amount of food: " + FoodCount);
	print("The "+ Dogsname + " ate half of the " + Name +"'s food");
	print("There is now " + Math + " left in the dog bowl");
	print("Now " + Name3 + " is going to starve");

}

	
		
	}

