using UnityEngine;
using System.Collections;

public class ButtonShop : Button
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

