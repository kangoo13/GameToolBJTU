using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

class RadialBuild : RadialButton
{
	public GameObject[] towers;

	public GameObject monsterPrefab;
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
		int cost = monsterPrefab.GetComponent<TowerData> ().levels[0].cost;
		return monster == null && gameManager.Gold >= cost;
	}

	//1
	void ButtonClicked () {
		//2
		if (canPlaceMonster ()) {
			//3
			monster = (GameObject) Instantiate(monsterPrefab, Obj.transform.position, Quaternion.identity);
			//4
			AudioSource audioSource = monster.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);

			gameManager.Gold -= monster.GetComponent<TowerData>().CurrentLevel.cost;


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


