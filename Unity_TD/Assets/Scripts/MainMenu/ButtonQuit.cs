using UnityEngine;
using System.Collections;
 
public class ButtonQuit : Button
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

