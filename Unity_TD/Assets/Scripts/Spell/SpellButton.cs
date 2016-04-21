using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpellButton : MonoBehaviour {

	private ISpell currentSpell;

	// Use this for initialization
	void Start () {
		currentSpell = TestPlayer.Instance.spellActive;
		GameObject spellPrefab = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(currentSpell.getSpellPrefabPath()) as GameObject;
		GameObject spellPrefabObj = Instantiate (spellPrefab) as GameObject;
		spellPrefabObj.transform.SetParent (this.transform, false);
		spellPrefabObj.GetComponent<ISpell>().prefabAnim = UnityEditor.AssetDatabase.LoadAssetAtPath<GameObject>(currentSpell.getPrefabAnimPath()) as GameObject;
	}


}
