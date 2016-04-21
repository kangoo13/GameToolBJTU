using UnityEngine;
using System.Collections;
using System;

class SpellManager : MonoBehaviour
{
	public static SpellManager Instance { get; private set; }
	public string[] spellList;

	private void Awake() {
		if (Instance != null) {
			DestroyImmediate(gameObject);
			return;
		}
		Instance = this;
		DontDestroyOnLoad(gameObject);
	}

	public object addSpellObject(GameObject obj, string spellName) {
		System.Type UserDefinedType = Type.GetType(spellName);
		object rtn = obj.AddComponent (UserDefinedType);
		return rtn;
	}


}

