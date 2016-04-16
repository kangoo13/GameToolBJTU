using UnityEngine;
using System.Collections;

public class ButtonFullSceen : MonoBehaviour
{
	private int status;

	public int Status {
		get {
			return status;
		}
	}

	void start(){
		PlayerPrefs.GetInt ("status_full_screen");
	}

	public void updateStatus(){
		if (PlayerPrefs.GetInt ("status_full_screen") == 0) {
			PlayerPrefs.SetInt ("status_full_screen", 1);
		} 
		else {
			PlayerPrefs.SetInt ("status_full_screen", 0);
		}
	}
}

