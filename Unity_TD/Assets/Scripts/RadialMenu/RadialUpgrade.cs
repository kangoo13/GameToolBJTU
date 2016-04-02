
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

class RadialUpgrade : RadialButton
{
	private GameManagerBehavior gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
	}


	public void ButtonClicked () {
		if (canUpgradeMonster()) {
			Obj.InstantiatedTower.increaseLevel();
			AudioSource audioSource = Obj.InstantiatedTower.GetComponent<AudioSource>();
			audioSource.PlayOneShot(audioSource.clip);
			gameManager.Gold -= Obj.InstantiatedTower.CurrentLevel.cost;
		}
		Destroy (this.transform.parent.gameObject);
	}

	private bool canUpgradeMonster() {
		if (Obj.InstantiatedTower != null) {
			TowerData monsterData = Obj.InstantiatedTower;
			TowerLevel nextLevel = monsterData.getNextLevel();
			if (nextLevel != null) {
				return gameManager.Gold >= nextLevel.cost;
			}
		}
		return false;
	}

}


