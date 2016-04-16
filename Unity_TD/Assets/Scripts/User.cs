using UnityEngine;
using System.Collections;

public class User : MonoBehaviour
{
	int level {
		get { return level; }
		set { level = PlayerPrefs.SetInt("level", value); }
	}
	int gold {
		get { return gold; }
		set { gold = PlayerPrefs.SetInt("gold", value); }
	}
	int current_mana {
		get { return current_mana; }
		set { current_mana = value; }
	}
	int mana_max {
		get { return mana_max; }
		set { 
			mana_max = PlayerPrefs.SetInt("mana_max", value);
		}
	}
	int mana_regen{
		get { return mana_regen;}
	}
	TalentTree user_talents {
		get { return user_talents; }
	}

	// Use this for initialization
	void Start ()
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
	}
}

