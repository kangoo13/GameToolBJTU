using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour {

	private ISpell currentSpell;
	private bool isSpellTriggered = false;

	// Use this for initialization
	void Start () {
		currentSpell = TestPlayer.Instance.spellActive;
		currentSpell.prefabAnim = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(currentSpell.getPrefabAnimPath()) as GameObject;
		Sprite imageSpell = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite>(currentSpell.getTexturePath()) as Sprite;
		this.transform.GetChild(0).GetComponent<Image> ().sprite = imageSpell;
	}

	public void triggerSpell()
	{
		isSpellTriggered = true;

	}

	void Update()
	{
		if (isSpellTriggered != false && Input.GetKeyDown(KeyCode.Mouse0)) {
			currentSpell.doAction (Input.mousePosition);
			isSpellTriggered = false;
		}
	}
}
