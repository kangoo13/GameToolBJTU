

using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

class RadialDemolish : RadialButton
{
	private GameManagerBehavior gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
	}

	//1
	public void ButtonClicked () {
		gameManager.Gold += Obj.InstantiatedTower.CurrentLevel.cost / 2;
		Destroy (this.transform.parent.gameObject);
		Destroy (Obj.InstantiatedTower.gameObject);
		Obj.InstantiatedTower = null;
	}

}


