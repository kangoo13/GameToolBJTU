using UnityEngine;
using System.Collections;

class User
{
	int level;
	int gold;
	Mana playerMana;
	TalentTree user_talents;
	public string spellActive = null;

	public Mana PlayerMana {
		get {
			return playerMana;
		}
	}

	// Use this for initialization
	public User ()
	{
		if (!PlayerPrefs.HasKey ("level")) {
			PlayerPrefs.SetInt ("level", 0);
		} 

		if (!PlayerPrefs.HasKey ("gold")) {
			PlayerPrefs.SetInt ("gold", 0);
		}

		if (!PlayerPrefs.HasKey("maxMana")){
			PlayerPrefs.SetInt ("maxMana", 100);
		}

		if (!PlayerPrefs.HasKey ("regenMana")) {
			PlayerPrefs.SetInt ("regenMana", 5);
		}

		level = PlayerPrefs.GetInt ("level");
		gold = PlayerPrefs.GetInt ("gold");
		playerMana = new Mana ();
		spellActive = "IceBall";
	}
}

