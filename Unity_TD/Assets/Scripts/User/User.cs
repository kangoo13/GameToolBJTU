using UnityEngine;
using System.Collections;

class User
{


	int level;
	int expMax;
	int currentExp;
	int gold;
	Mana playerMana;
	TalentTree user_talents;
	public string spellActive = null;

	public int Gold {
		get {
			return gold;
		}
		set {
			gold = value;
			PlayerPrefs.SetInt ("gold", value);

		}
	}

	public int Level {
		get {
			return level;
		}
		set {
			level = value;
			PlayerPrefs.SetInt ("level", value);

		}
	}

	public int ExpMax {
		get {
			return expMax;
		}
		set {
			expMax = value;
			PlayerPrefs.SetInt ("expMax", value);

		}
	}

	public int CurrentExp {
		get {
			return currentExp;
		}
		set {
			currentExp = value;
			PlayerPrefs.SetInt ("currentExp", value);

		}
	}

	public void addExp (int totalGoldWon)
	{
		if (currentExp + totalGoldWon >= expMax) {
			Level += 1;
			int total = currentExp + totalGoldWon;
			CurrentExp = total - expMax;
			ExpMax = level * 1000;
		} else
			CurrentExp += totalGoldWon;
	}

	public Mana PlayerMana {
		get {
			return playerMana;
		}
	}

	// Use this for initialization
	public User ()
	{
		if (!PlayerPrefs.HasKey ("level")) {
			PlayerPrefs.SetInt ("level", 1);
		} 
		if (!PlayerPrefs.HasKey ("currentExp")) {
			PlayerPrefs.SetInt ("currentExp", 0);
		} 


		if (!PlayerPrefs.HasKey ("gold")) {
			PlayerPrefs.SetInt ("gold", 0);
		}
		if (!PlayerPrefs.HasKey ("activeSpell")) {
			PlayerPrefs.SetString ("activeSpell", "FireBall");
		}

		level = PlayerPrefs.GetInt ("level");
		gold = PlayerPrefs.GetInt ("gold");
		currentExp = PlayerPrefs.GetInt ("currentExp");
		expMax = level * 1000;
		playerMana = new Mana ();
		spellActive = PlayerPrefs.GetString("activeSpell");	}
}

