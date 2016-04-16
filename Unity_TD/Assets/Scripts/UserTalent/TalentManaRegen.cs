using UnityEngine;
using System.Collections;

class TalentManaRegen : Talent
{
	public TalentManaRegen(){
		talent_name = "Upgrade max regen";
		description = "Increase mana regeneration.";
		if (!PlayerPrefs.HasKey ("mana_regen_point")) {
			PlayerPrefs.SetInt ("mana_regen_point", 0);
		} 
		current_point = PlayerPrefs.GetInt ("mana_regen_point");
		UpdateEffect ();
	}

	void UpdateEffect(){
		for (int i = 0; i <= current_point; i++){
			PlayerPrefs.SetInt ("mana_regen", PlayerPrefs.GetInt ("mana_regen") + 2);
		}
	}
}

