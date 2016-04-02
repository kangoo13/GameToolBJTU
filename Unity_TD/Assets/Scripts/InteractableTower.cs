using UnityEngine;
using System.Collections;

//Add this script to game objects with which you want to interact
public class InteractableTower : MonoBehaviour {

	private GameObject instantiatedTower = null;

	//dummy class for storing the menu info (this would likely be
	//handled by your game's character data or other gameplay data)
	[System.Serializable]
	public class Action {
		public GameObject[] buttonPrefabs;
	}



	//this is where you set your menu options in the inspector (again,
	//your game data should ultimately handle this
	public Action[] options;

	void OnMouseDown(){
		if (instantiatedTower == null)
			RadialMenuSpawner.ins.SpawnMenu(this, options[0].buttonPrefabs);
	}
		

}
