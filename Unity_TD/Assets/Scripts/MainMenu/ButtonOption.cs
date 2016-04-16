using UnityEngine;
using System.Collections;

class ButtonOption : Button
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

