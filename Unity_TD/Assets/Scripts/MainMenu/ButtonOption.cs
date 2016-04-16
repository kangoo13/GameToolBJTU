using UnityEngine;
using System.Collections;

public class ButtonOption : Button
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

