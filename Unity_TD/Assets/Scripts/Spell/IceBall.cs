using System;

using System;
using UnityEngine;

public class IceBall : ISpell
{
	public Sprite imageSpell { get; set; }
	public GameObject prefabAnim { get; set; }
	public float initialDamage { get; set; }

	public IceBall()
	{
		initialDamage = 3f;
	}


	public string getTexturePath()
	{
		return "Assets/Images/Spell/ice-ball-icon-th.png";
	}

	public string getPrefabAnimPath()
	{
		return "Assets/Prefabs/SpellAnim/IceBallAnimPrefab.prefab";
	}

	public void doAction(Vector3 mousePosition)
	{

		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		GameObject animObj = UnityEngine.Object.Instantiate (prefabAnim) as GameObject;
		animObj.transform.position = new Vector3 (ray.origin.x, ray.origin.y, 0f);
		Collider2D[] hit = Physics2D.OverlapCircleAll(new Vector2(ray.origin.x, ray.origin.y), 2f);
		foreach (Collider2D enemy in hit) {
			if (enemy.tag == "Enemy") {
				enemy.gameObject.GetComponentInChildren<HealthBar> ().removeHealth (initialDamage);
				enemy.gameObject.GetComponent<MonsterInfo> ().touchedByIce ();
			}
		}
	}
}


