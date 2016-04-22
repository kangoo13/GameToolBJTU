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
			return maxMana;
		}
		set {
			maxMana = value;
		}
	}

	public int RegenMana {
		get {
			return maxMana;
		}
		set {
			maxMana = value;
		}
	}

	public Mana()
	{
		maxMana = PlayerPrefs.GetInt ("maxMana");
		currentMana = maxMana;
		regenMana = PlayerPrefs.GetInt ("regenMana");
	}
}


