using UnityEngine;
using System.Collections;

class Mana
{
	private int maxMana;
	private int currentMana;
	private int regenMana;

	public int MaxMana {
		get {
			return maxMana;
		}
		set {
			maxMana = value;
		}
	}

	public int CurrentMana {
		get {
			return currentMana;
		}
		set {
			currentMana = value;
		}
	}

	public int RegenMana {
		get {
			return regenMana;
		}
		set {
			regenMana = value;
		}
	}

	public Mana()
	{
		if (!PlayerPrefs.HasKey ("maxMana"))
			PlayerPrefs.SetInt ("maxMana", 100);
		if (!PlayerPrefs.HasKey ("regenMana"))
			PlayerPrefs.SetInt ("regenMana", 1);
		maxMana = PlayerPrefs.GetInt ("maxMana");
		currentMana = maxMana;
		regenMana = PlayerPrefs.GetInt ("regenMana");
	}
}


