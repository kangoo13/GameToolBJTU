using UnityEngine;
using System.Collections;

interface ISpell {

	void doAction(Vector3 mousePosition);
	string getTexturePath();
	string getPrefabAnimPath();
	Sprite imageSpell { get; set; }
	GameObject prefabAnim { get; set; }
	float initialDamage { get; set; }
}
