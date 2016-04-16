using UnityEngine;
using System.Collections;

public class ButtonFullSceen : MonoBehaviour
{
	int status {
		get { return status; }
	} = 0;

	void start(){
		status = PlayerPrefs.GetInt ("status_full_screen");
	}

	public void updateStatus(){
		if (PlayerPrefs.GetInt ("status_full_screen") == 0) {
			status = PlayerPrefs.SetInt ("status_full_screen", 1);
		} 
		else {
			status = PlayerPrefs.SetInt ("status_full_screen", 0);
		}
	}
}

