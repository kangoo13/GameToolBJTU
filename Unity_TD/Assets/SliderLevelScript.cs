using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderLevelScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<Slider> ().maxValue = ManageTheGame.Instance.Player.ExpMax;
		GetComponent<Slider> ().value = ManageTheGame.Instance.Player.CurrentExp;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
