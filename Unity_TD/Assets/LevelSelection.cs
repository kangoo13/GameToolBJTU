using UnityEngine;
using System.Collections;

public class LevelSelection : MonoBehaviour {

	public GameObject topMenuObj;

	public void displayLevelSelection() {
		topMenuObj.GetComponent<TopMainMenuHandle> ().displayLevelSelection ();
	}
}
