using UnityEngine;
using System.Collections;

public class AdjustItemShop : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RectTransform contentPanelRt = transform.parent.GetComponent<RectTransform> ();
		contentPanelRt.sizeDelta = new Vector2 (contentPanelRt.sizeDelta.x / 1.25f, 0f); 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
