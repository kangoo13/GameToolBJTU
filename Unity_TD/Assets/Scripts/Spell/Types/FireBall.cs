using System;
using UnityEngine;

public class FireBall : MonoBehaviour, ISpell
{
	public int manaCost { get; set; }
	public Sprite imageSpell { get; set; }
	public GameObject prefabAnim { get; set; }
	public float initialDamage { get; set; }

	public FireBall()
	{
		initialDamage = 40f;
		manaCost = 50;
	}

	public string getSpellName()
	{
		return "FireBall";
	}
	/*
	public string getTexturePath()
	{
		return "Assets/Images/Spell/fire-ball-icon-th.png";
	}

	public string getPrefabAnimPath()
	{
		return "Assets/Prefabs/SpellAnim/FireBallAnimPrefab.prefab";
	}

	public string getSpellPrefabPath()
	{
		return "Assets/Prefabs/Spells/FireBall.prefab";
	}*/

	public string getTexturePath()
	{
		return "fire-ball-icon-th";
	}

	public string getPrefabAnimPath()
	{
		return "FireBallAnimPrefab";
	}

	public string getSpellPrefabPath()
	{
		return "FireBall.prefab";
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
			}
		}
	}


}

