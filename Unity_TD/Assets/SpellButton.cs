using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour {

	private ISpell currentSpell;

	// Use this for initialization
	void Start () {
		
	}

	public void doSpell()
	{
		currentSpell.doAction ();
	}

	// Update is called once per frame
	void Update () {
		currentSpell = TestPlayer.Instance.spellActive;
		this.transform.GetChild(0).GetComponent<Image> ().sprite = currentSpell.imageSpell;
	}
}
