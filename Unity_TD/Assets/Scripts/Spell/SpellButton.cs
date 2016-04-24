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
		obj.GetComponent<ISpell>().prefabAnim = Resources.Load(currentSpell.getPrefabAnimPath()) as GameObject;
		Texture2D text = Resources.Load(currentSpell.getTexturePath()) as Texture2D;
		obj.GetComponent<Image>().sprite = Sprite.Create(text, new Rect(0, 0, text.width, text.height), new Vector2(0.5f, 0.5f));
		obj.GetComponent<Button> ().onClick.AddListener(() => triggerSpell());
	}

	public void triggerSpell()
	{
		if (ManageTheGame.Instance.Player.PlayerMana.CurrentMana >= currentSpell.manaCost) {
			isSpellTriggered = true;
			ManageTheGame.Instance.Player.PlayerMana.CurrentMana -= currentSpell.manaCost;
			GameManagerBehavior.Instance.ManaLabel.text = ManageTheGame.Instance.Player.PlayerMana.CurrentMana.ToString();
		}

	}

	void Update()
	{
		if (isSpellTriggered != false && Input.GetKeyDown(KeyCode.Mouse0)) {
			currentSpell.doAction (Input.mousePosition);
			isSpellTriggered = false;
		}
	}

}
