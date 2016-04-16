using UnityEngine;
using System.Collections;

public abstract class Talent
{
	protected string talent_name{
		get { return talent_name; }
	}
	protected string description{
		get { return description; }
	}
	protected int current_point{
		get { return current_point; }
	}
	protected int max_point{
		get { return max_point; }
	} = 5;
	protected int effect {
		get { return effect; }	
	} = 0;

	public void AddPoint(string key){
		if (PlayerPrefs.GetInt(key) < max_point){
			PlayerPrefs.SetInt (key, PlayerPrefs.GetInt(key) += 1);
		}
	}
}

