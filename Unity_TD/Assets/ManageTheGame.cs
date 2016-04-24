using UnityEngine;
using System.Collections;

class ManageTheGame : MonoBehaviour
{
	public static ManageTheGame Instance { get; private set; }
	private User player;

	public User Player {
		get {
			return player;
		}
	}

	private void Awake() {
		if (Instance != null) {
			DestroyImmediate(gameObject);
			return;
		}
		Instance = this;
		DontDestroyOnLoad(gameObject);

	}

	public void Start()
	{
		
		player = new User ();
	}


}

