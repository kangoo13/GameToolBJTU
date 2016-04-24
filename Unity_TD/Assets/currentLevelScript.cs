using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class currentLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Text> ().text = "LEVEL " + ManageTheGame.Instance.Player.Level.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
