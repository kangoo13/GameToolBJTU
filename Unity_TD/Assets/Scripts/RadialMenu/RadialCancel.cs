

using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

class RadialCancel : RadialButton
{
	public void ButtonClicked () {
		Destroy (this.transform.parent.gameObject);
	}

}


