 using UnityEngine;
using System.Collections;

class TestPlayer {

	private static TestPlayer instance;

	private TestPlayer() {}
	public FireBall spellActive = new FireBall();

	public static TestPlayer Instance
	{
		get 
		{
			if (instance == null)
			{
				instance = new TestPlayer();
			}
			return instance;
		}
	}
}
