using System;
using UnityEngine;

class ButtonSelectLevel : UnityEngine.UI.Button
{
	public virtual void OnSelected(String sceneName) {
		GameManager.Instance.LoadScene (sceneName);
	}
}

