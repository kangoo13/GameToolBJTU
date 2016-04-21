using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour {

	private ISpell currentSpell;

	// Use this for initialization
	void Start () {
		GameObject obj = transform.GetChild (0).gameObject;
		currentSpell = (ISpell)SpellManager.Instance.addSpellObject (obj, ManageTheGame.Instance.Player.spellActive);
		obj.GetComponent<ISpell>().prefabAnim = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(currentSpell.getPrefabAnimPath()) as GameObject;
	}


}
