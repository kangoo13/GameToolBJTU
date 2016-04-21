using UnityEngine;
using System.Collections;

class User
{
	int level;
	int gold;
	int current_mana;
	int mana_max;
	int mana_regen;
	TalentTree user_talents;
	public string spellActive = null;

	// Use this for initialization
	public User ()
	{
		if (!PlayerPrefs.HasKey ("level")) {
			PlayerPrefs.SetInt ("level", 0);
		} 

		if (!PlayerPrefs.HasKey ("gold")) {
			PlayerPrefs.SetInt ("gold", 0);
		}

		if (!PlayerPrefs.HasKey("mana_max")){
			PlayerPrefs.SetInt ("mana_max", 100);
		}

		if (!PlayerPrefs.HasKey ("mana_regen")) {
			PlayerPrefs.SetInt ("mana_regen", 5);
		}

		level = PlayerPrefs.GetInt ("level");
		gold = PlayerPrefs.GetInt ("gold");
		mana_max = PlayerPrefs.GetInt ("mana_max");
		mana_regen = 5;
		current_mana = mana_max;
		spellActive = "FireBall";
	}
}

