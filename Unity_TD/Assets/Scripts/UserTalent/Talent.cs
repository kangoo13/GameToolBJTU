using UnityEngine;
using System.Collections;

abstract class Talent
{
	protected string talent_name;
	protected string description;
	protected int current_point;
	protected int max_point = 5;
	protected int effect = 0;

	public void AddPoint(string key){
		if (PlayerPrefs.GetInt(key) < max_point){
			PlayerPrefs.SetInt (key, PlayerPrefs.GetInt(key) + 1);
		}
	}
}

