using UnityEngine;
using System.Collections;

class ButtonQuit : Button
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

