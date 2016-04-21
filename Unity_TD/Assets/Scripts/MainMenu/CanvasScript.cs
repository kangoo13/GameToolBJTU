using UnityEngine;
using System.Collections;

public class CanvasScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RectTransform rt = GetComponent<RectTransform> ();
		rt.sizeDelta = new Vector2 (800f, rt.rect.height);


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
