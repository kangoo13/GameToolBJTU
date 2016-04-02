using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Add this to your menu prefab
public class RadialMenu : MonoBehaviour {

	// Use this for initialization
	public void SpawnButtons (GameObject[] buttonPrefab, InteractableTower obj) {
		for (int i = 0; i < buttonPrefab.Length; i++){
			GameObject newButtonGO = Instantiate(buttonPrefab[i]) as GameObject;
			RadialButton newButton = newButtonGO.GetComponent<RadialButton> ();
			newButton.transform.SetParent(transform, false);
			float theta = (2 * Mathf.PI / buttonPrefab.Length) * i;
			float xPos = Mathf.Sin(theta);
			float yPos = Mathf.Cos(theta);
			newButton.transform.localPosition = new Vector3 (xPos, yPos, 0f) * 50f;
			newButton.myMenu = this;
			newButton.Anim();
			newButton.Obj = obj;
		}
	}


}
