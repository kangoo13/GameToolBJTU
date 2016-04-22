using UnityEngine;
using System.Collections;

public class LevelSelection : MonoBehaviour {

	public GameObject topMenuObj;

	public void displayLevelSelection() {
		topMenuObj.GetComponent<TopMainMenuHandle> ().displayLevelSelection ();
	}

	void Start() {
		RectTransform rt = GetComponentInParent<AdjustPositionMainMenu> ().gameObject.GetComponent<RectTransform> ();
		RectTransform thisRt = GetComponent<RectTransform> ();

		thisRt.sizeDelta = new Vector2 (rt.sizeDelta.x / 7.68f, rt.sizeDelta.y / 4.51f);
	}
}
