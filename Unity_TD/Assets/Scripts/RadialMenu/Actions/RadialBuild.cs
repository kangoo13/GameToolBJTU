using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RadialBuild : RadialButton
{
	public GameObject towerMenuPrefab;
	private GameObject monster;
	private GameManagerBehavior gameManager;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
	}

	// Update is called once per frame
	void Update () {

	}

	private bool canPlaceMonster() {
		int cost = monster.GetComponent<TowerData> ().levels[0].cost;
		return gameManager.Gold >= cost;
	} 

	void ButtonClicked()
	{
		GameObject menu = Instantiate (towerMenuPrefab) as GameObject;
		menu.transform.SetParent (this.transform.parent.transform.parent.transform, false);
		menu.GetComponent<TowerBuildPanel> ().Initialize (this);

		//Destroy (this.transform.parent.gameObject);

	}

	//1
	public void createTower (GameObject monstero) {
		monster = monstero;
		//2
		if (canPlaceMonster ()) {
			//3

			monster = (GameObject) Instantiate(monster, Obj.transform.position, Quaternion.identity);
			//4
			AudioSource audioSource = monster.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);

			gameManager.Gold -= monster.GetComponent<TowerData>().CurrentLevel.cost;
			Obj.InstantiatedTower = monster.GetComponent<TowerData> ();

		} else if (canUpgradeMonster()) {
			monster.GetComponent<TowerData>().increaseLevel();
			AudioSource audioSource = monster.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);

			gameManager.Gold -= monster.GetComponent<TowerData>().CurrentLevel.cost;


		}
		Destroy (this.transform.parent.gameObject);
	}

	private bool canUpgradeMonster() {
		if (monster != null) {
			TowerData monsterData = monster.GetComponent<TowerData> ();
			TowerLevel nextLevel = monsterData.getNextLevel();
			if (nextLevel != null) {
				return gameManager.Gold >= nextLevel.cost;
			}
		}
		return false;
	}

}


