using UnityEngine;
using System.Collections;

public class TopMainMenuHandle : MonoBehaviour {
	public GameObject[] _levelContent;
	public GameObject[] _shopContent;
	public GameObject	_shopButton;
	public GameObject	_backButton;

	// Use this for initialization
	void Start () {
		_shopButton.SetActive(true);
		_backButton.SetActive(false);
		foreach (GameObject obj in _levelContent) {
			GameObject objInst = Instantiate (obj) as GameObject;
			objInst.transform.SetParent (this.transform, false);
			objInst.name = obj.name;
		}
		GetComponentInParent<AdjustPositionMainMenu> ().adjustTopMenu ();
	}

	public void displayShop()
	{
		_shopButton.SetActive(false);
		_backButton.SetActive(true);
		foreach (Transform tfm in transform) {
			Destroy (tfm.gameObject);
		}
		foreach (GameObject obj in _shopContent) {
			GameObject objInst = Instantiate (obj) as GameObject;
			objInst.transform.SetParent (this.transform, false);
			objInst.name = obj.name;
		}
		StartCoroutine (UpdateTopMenu());

	}

	IEnumerator UpdateTopMenu() {
		yield return new WaitForFixedUpdate();
		GetComponentInParent<AdjustPositionMainMenu> ().adjustTopMenu ();
	}

	public void displayLevelSelection()
	{
		_shopButton.SetActive(true);
		_backButton.SetActive(false);
		foreach (Transform tfm in transform) {
			Destroy (tfm.gameObject);
		}
		foreach (GameObject obj in _levelContent) {
			GameObject objInst = Instantiate (obj) as GameObject;
			objInst.transform.SetParent (this.transform, false);
			objInst.name = obj.name;
		}
		StartCoroutine (UpdateTopMenu());
	}

}
