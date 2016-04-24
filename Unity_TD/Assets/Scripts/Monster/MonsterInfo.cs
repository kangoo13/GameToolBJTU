using UnityEngine;
using System.Collections;

public class MonsterInfo : MonoBehaviour {


	public bool isPoisoned = false;
	public bool isImmunedToPoison = false;
	public bool isImmunedToIce = false;
	public bool isImmunedToStunned = false;
	public bool isRegenerable = false;
	public int goldValue = 0;

	public int GoldValue {
		get {
			return goldValue;
		}
	}

	public void touchedByIce()
	{
		if (!isImmunedToIce)
			StartCoroutine(iced());
	}

	public void touchedByStun()
	{
		if (!isImmunedToStunned)
			StartCoroutine(stunned());
	}

	public void touchedByPoison(int damage)
	{
		if (!isImmunedToPoison)
			StartCoroutine(poisonned(damage));
	}

	IEnumerator iced() {
		float i = 0f;
		while (i <= 2f) {
			GetComponent<MoveEnemy> ().isIced = true;
			i += 0.05f;
			yield return new WaitForSeconds(0.05f);
		}

		GetComponent<MoveEnemy> ().isIced = false;
	}

	IEnumerator stunned() {
		float i = 0f;
		while (i <= 2f) {
			GetComponent<MoveEnemy> ().isStunned = true;
			i += 0.05f;
			yield return new WaitForSeconds(0.05f);
		}
		GetComponent<MoveEnemy> ().isStunned = false;
	}

	IEnumerator poisonned(int damage) {
		int i = 0;
		while (i != 3) {
			i++;
			float rdamage = damage / 10f;
			GetComponentInChildren<HealthBar> ().removeHealth (rdamage);
			yield return new WaitForSeconds(1);
		}
	}
	// Update is called once per frame
	void Update () {
		HealthBar hb = GetComponentInChildren<HealthBar> ();
		if (isRegenerable && hb.currentHealth < hb.maxHealth)
			hb.currentHealth += Mathf.Min(hb.maxHealth / 200f, hb.maxHealth);
	}
}
