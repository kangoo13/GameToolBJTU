using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GoldDisplay : MonoBehaviour {

	private Text _goldText;
	// Use this for initialization
	void Start () {
		_goldText = GetComponentInChildren<Text> ();
		StartCoroutine (UpdateGold ());
	}
	
	IEnumerator UpdateGold()
	{
		while (true) {
			if (_goldText.text != ManageTheGame.Instance.Player.Gold.ToString ()) {
				_goldText.text = ManageTheGame.Instance.Player.Gold.ToString ();
			}
			yield return new WaitForSeconds (0.5f);
		}
	}
}
