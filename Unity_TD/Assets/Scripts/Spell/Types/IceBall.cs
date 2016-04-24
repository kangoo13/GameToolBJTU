using System;
using UnityEngine;

public class IceBall : MonoBehaviour, ISpell
{
	public int manaCost { get; set; }
	public Sprite imageSpell { get; set; }
	public GameObject prefabAnim { get; set; }
	public float initialDamage { get; set; }

	public IceBall()
	{
		initialDamage = 20f;
		manaCost = 50;
	}

	public string getSpellName()
	{
		return "IceBall";
	}
		
	public string getSpellPrefabPath()
	{
		return "Assets/Prefabs/Spells/IceBall.prefab";
	}

	public string getTexturePath()
	{
		return "ice-ball-icon-th";
	}

	public string getPrefabAnimPath()
	{
		return "IceBallAnimPrefab";
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


