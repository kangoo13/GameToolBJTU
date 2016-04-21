using UnityEngine;
using System.Collections;

interface ISpell {

	void doAction(Vector3 mousePosition);
	string getTexturePath();
	string getPrefabAnimPath();
	string getSpellName();
	string getSpellPrefabPath ();
	Sprite imageSpell { get; set; }
	GameObject prefabAnim { get; set; }
	float initialDamage { get; set; }
}
