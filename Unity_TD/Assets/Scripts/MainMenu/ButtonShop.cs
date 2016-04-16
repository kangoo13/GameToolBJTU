using UnityEngine;
using System.Collections;

class ButtonShop : Button
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

