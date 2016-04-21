using UnityEngine;
using System.Collections;

public class AdjustPositionMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		Vector2 thisPos = GetComponent<RectTransform> ().sizeDelta;
		RectTransform topRt = GameObject.Find("Canvas/TopPanel").GetComponent<RectTransform>();
		Debug.Log (thisPos.x);
		topRt.position = new Vector3 (thisPos.x / 1.96987951807f, topRt.position.y, topRt.position.z);
	}

}
