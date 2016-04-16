using System;
using UnityEngine;

public class FireBall : ISpell
{
	public Sprite imageSpell { get; set; }


	public FireBall()
	{
		string texture = "Assets/Images/Spell/fire-ball-icon-th.png";
		imageSpell = Resources.Load(texture) as Sprite;

	}

	public void doAction()
	{
			
	}
}

