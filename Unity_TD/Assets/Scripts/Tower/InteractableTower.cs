using UnityEngine;
using System.Collections;

//Add this script to game objects with which you want to interact
public class InteractableTower : MonoBehaviour {

	private TowerData instantiatedTower = null;

	public TowerData InstantiatedTower {
		get {
			return instantiatedTower;
		}
		set {
			instantiatedTower = value;
		}
	}

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
		GameManagerBehavior gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
		if (!gameManager.isTowerPanelOpened) {
			if (instantiatedTower == null)
				RadialMenuSpawner.ins.SpawnMenu (this, options [0].buttonPrefabs);
			else if (instantiatedTower.upgradable ())
				RadialMenuSpawner.ins.SpawnMenu (this, options [1].buttonPrefabs);
			else
				RadialMenuSpawner.ins.SpawnMenu (this, options [2].buttonPrefabs);
		}
	}
		

}
