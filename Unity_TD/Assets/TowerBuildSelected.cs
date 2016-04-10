using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TowerBuildSelected : MonoBehaviour {
	GameObject tower;
	private RadialBuild reference = null;

	public RadialBuild Reference {
		get {
			return reference;
		}
		set {
			reference = value;
		}
	}

	// Use this for initialization
	void Start () {
	
	}

	public void setTowerImage(GameObject TowerPrefab)
	{
		tower = TowerPrefab;
		this.GetComponent<Image> ().sprite = tower.GetComponentInChildren<SpriteRenderer> ().sprite;
	}

	public void buildThisTower()
	{
		reference.createTower (tower);
		GameManagerBehavior gameManager = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
		gameManager.isTowerPanelOpened = false;
		Destroy (transform.parent.gameObject);
	}

}
