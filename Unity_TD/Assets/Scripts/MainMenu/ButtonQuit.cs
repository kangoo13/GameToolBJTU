using UnityEngine;
using System.Collections;
<<<<<<< HEAD
 
public class ButtonQuit : Button
=======

class ButtonQuit : Button
>>>>>>> ae71999d58f3b6b7adcaa72eab156f97a9247fda
{
	public virtual void OnSelected (string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

