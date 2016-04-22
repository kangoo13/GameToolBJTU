using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using System.CodeDom;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class SpellMenu : MonoBehaviour {

	private LevelSelection instantiatedLevel = null;
	private int x = 100;
	private int y = 0;

	public GameObject obj;
	public LevelSelection InstantiatedLevel {
		get {
			return instantiatedLevel;
		}
		set {
			instantiatedLevel = value;
		}
	}
		
	void Start() {
		int i = 0;

		double width = GetComponent<RectTransform> ().rect.x;
		double height = GetComponent<RectTransform> ().rect.y;

		RectTransform objRt = GetComponentInParent<AdjustPositionMainMenu> ().gameObject.GetComponent<RectTransform>();
		RectTransform objTopRt = GetComponentInParent<TopMainMenuHandle> ().gameObject.GetComponent<RectTransform>();

		RectTransform thisRt = GetComponent<RectTransform> ();
		thisRt.sizeDelta = new Vector2 (objTopRt.sizeDelta.x, 0f);

		foreach (String spellName in SpellManager.Instance.spellList) {

			GameObject objSpell = Instantiate (obj) as GameObject;
			objSpell.transform.SetParent (this.transform, false);

			RectTransform	rt = objSpell.GetComponent<RectTransform> ();

			//if (i % 2 == 0) {
			rt.localPosition = new Vector3 (x * i, y, 0f);
			/*} else {
				rt.anchorMin = new Vector2 (0, 0);
				rt.anchorMax = new Vector2 (0, 0);
				rt.pivot = new Vector2 (0, 0);
				rt.localPosition = new Vector3 ((x * i), y * -1, 0f);
			}*/
			ISpell spell = (ISpell)SpellManager.Instance.addSpellObject (objSpell, spellName);
			GameObject imageChild = objSpell.transform.GetChild (0).gameObject;
			RectTransform imageRt = imageChild.GetComponent<RectTransform> ();
			imageChild.GetComponentInChildren<Image> ().sprite = UnityEditor.AssetDatabase.LoadAssetAtPath<Sprite> (spell.getTexturePath()) as Sprite;
			imageRt.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0, objRt.sizeDelta.y / -28.6666666667f);
			imageRt.GetComponent<RectTransform> ().sizeDelta = new Vector2 (objRt.sizeDelta.x / 15.5714285714f, objRt.sizeDelta.y / 9.05263157895f);			i++;
		}

		i = 0;
		int l = SpellManager.Instance.spellList.Length - 5;
		int total_ajout = 0;
		if (l > 0) {
			total_ajout = 150;
			while (i != l) {
				/*if (i == 2) {

				}*/
				RectTransform rt = GetComponent<RectTransform> ();
				//			RectTransform rt = transform.parent.GetComponent<RectTransform> ();
				rt.sizeDelta = new Vector2 (rt.sizeDelta.x + total_ajout, rt.sizeDelta.y);
				i++;
			}
		}

		/*		int i = 0;
		foreach (GameObject level in levelObject) {
			GameObject objLevel = Instantiate (level) as GameObject;
			objLevel.transform.SetParent (this.transform, false);

			RectTransform	rt = objLevel.GetComponent<RectTransform> ();

			if (i % 2 == 0) {
				rt.localPosition = new Vector3 (x + (x * i), y, 0f);
			} else {
				rt.anchorMin = new Vector2 (0, 0);
				rt.anchorMax = new Vector2 (0, 0);
				rt.pivot = new Vector2 (0, 0);
				rt.localPosition = new Vector3 ((x * i), y * -1, 0f);
			}
			i++;
		}*/
	}
}
