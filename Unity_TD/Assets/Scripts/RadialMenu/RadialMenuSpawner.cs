using UnityEngine;
using System.Collections;

//Add this to the Canvas where the menu should appear
public class RadialMenuSpawner : MonoBehaviour {

	public static RadialMenuSpawner ins;
	public RadialMenu menuPrefab;
	private GameObject menuInstantied = null;//prefab menu to instantiate

	//TODO: fix this terrible singleton setup
	void Awake(){
		ins = this;
	}



	//instantiates the menu at the position of the mouse
	public void SpawnMenu(InteractableTower obj, GameObject[] prefabButton){
		if (menuInstantied != null)
			Destroy (menuInstantied);
		RadialMenu newMenu = Instantiate(menuPrefab) as RadialMenu;
		newMenu.transform.SetParent (transform, false);
		newMenu.transform.position = Input.mousePosition;
		newMenu.SpawnButtons(prefabButton, obj);
		menuInstantied = newMenu.gameObject;
	}
		

}
