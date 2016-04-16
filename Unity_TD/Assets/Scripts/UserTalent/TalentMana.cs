using UnityEngine;
using System.Collections;

public class TalentMana : Talent
{
	public TalentMana(){
		talent_name = "Upgrade max mana";
		description = "Increase the maximum mana.";
		if (!PlayerPrefs.HasKey ("mana_point")) {
			PlayerPrefs.SetInt ("mana_point", 0);
		} 
		current_point = PlayerPrefs.GetInt ("mana_point");
		UpdateEffect ();
	}

	void UpdateEffect(){
		for (int i = 0; i <= current_point; i++){
			PlayerPrefs.SetInt ("mana_max", PlayerPrefs.GetInt ("mana_max") += 5);
		}
	}
}

