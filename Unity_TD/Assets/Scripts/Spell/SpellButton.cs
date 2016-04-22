using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour {

	private ISpell currentSpell;
	private bool isSpellTriggered = false;

	// Use this for initialization
	void Start () {
		GameObject obj = transform.GetChild (0).gameObject;
		currentSpell = (ISpell)SpellManager.Instance.addSpellObject (obj, ManageTheGame.Instance.Player.spellActive);
		obj.GetComponent<ISpell>().prefabAnim = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(currentSpell.getPrefabAnimPath()) as GameObject;
		obj.GetComponent<Image>().sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite> (currentSpell.getTexturePath()) as Sprite;
		obj.GetComponent<Button> ().onClick.AddListener(() => triggerSpell());
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
