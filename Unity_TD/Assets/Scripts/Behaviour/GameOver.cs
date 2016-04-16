using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void RestartLevel () {
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene (scene.buildIndex);
	}

}
