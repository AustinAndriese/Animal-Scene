using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {

public bool Key = false;

void OnMouseDown()
{
	
	if(Key == true) 
		print("Open Door");

	if(Name == "Dogo")
	print("Dog is named Dogo");

	if(FoodCount > 1)
	print(Name + "is out of food");

	if(1 + 1 == 2)
	print("True, 1 + 1 = 2");

	if(Math == 3)
	print("Yes, it's 3");

	if(Dogsnameinspanish == "Perro")
	print("Dog's name is in Spanish");

	if(FoodCount < 1)
	print("Dog has plenty of food");

	if(Cat == "Gato")
	print("Cat in spanish is Gato");
	
	if(Math > 2)
	print(Math + "is larger than 2");

	if(Math != 2)
	print(Math + "is larger than 2");

//if statements are pretty useful in my mind. They allow you to use the computer to say/do things with variables.
//The example used was pretty helpful with the key, it made me think of a Zelda game where you need to find keys
//to open doors which will eventually get you to the boss. The principle can be used in many different scenarios.
//I feel like it will overall help shorten your code and make game functions more personable.


	}





public string Name;
public int FoodCount;
public string Dogsnameinspanish;
public float Math;
public string Cat;

	
		
	}

