using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void RestartLevel () {
		ManageTheGame.Instance.Player.Gold += GameManagerBehavior.Instance.totalGoldWon;
		ManageTheGame.Instance.Player.addExp (GameManagerBehavior.Instance.totalGoldWon);
		SceneManager.LoadScene ("mainMenu");
	}

}
