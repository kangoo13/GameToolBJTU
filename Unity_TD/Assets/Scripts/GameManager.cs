using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public static GameManager Instance { get; private set; }
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

	public void LoadLevel(string level){
	}

	public void LoadScene(string scene){
	}
}

