using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class nextLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "LEVEL " + (ManageTheGame.Instance.Player.Level + 1).ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
