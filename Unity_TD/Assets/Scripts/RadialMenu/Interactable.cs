using UnityEngine;
using System.Collections;

//Add this script to game objects with which you want to interact
public class Interactable : MonoBehaviour {

	//dummy class for storing the menu info (this would likely be
	//handled by your game's character data or other gameplay data)
	[System.Serializable]
	public class Action {
		public Color color;
		public Sprite sprite;
	}
		

	//this is where you set your menu options in the inspector (again,
	//your game data should ultimately handle this
	public Action[] options;

	void OnMouseDown(){
		//tell the canvas to spawn a menu
		RadialMenuSpawner.ins.SpawnMenu(this);
	}

}
