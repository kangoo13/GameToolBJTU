﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class GameManagerBehavior : MonoBehaviour {
	public bool isTowerPanelOpened = false;
	private static GameManagerBehavior instance;
	public Text goldLabel;
	public Text manaLabel;
	private int gold;
	public int totalGoldWon = 0;

	public Text ManaLabel {
		get {
			return manaLabel;
		}
		set{
			manaLabel = value;
		}
	}

	public int Gold {
		get {
			return gold;
		}
		set  {
			gold = value;
			goldLabel.text = gold.ToString ();
		}
	}

	public static GameManagerBehavior Instance
	{
		get 
		{
			return instance;
		}
	}

	public Text waveLabel;
	public GameObject[] nextWaveLabels;

	public bool gameOver = false;

	private int wave;
	public int Wave {
		get { return wave; }
		set {
			wave = value;
			if (!gameOver) {
				for (int i = 0; i < nextWaveLabels.Length; i++) {
					nextWaveLabels[i].GetComponent<Animator>().SetTrigger("nextWave");
				}
			}
			waveLabel.text = "WAVE : " + (wave + 1);
		}
	}

	public Text healthLabel;
	public GameObject[] healthIndicator;


	// add function regen mana each 5 sec

	private int health;
	public int Health {
		get { return health; }
		set {
			// 1
			if (value < health) {
				Camera.main.GetComponent<CameraShake>().Shake();
			}
			// 2
			health = value;
			healthLabel.text = health.ToString();
			// 2
			if (health <= 0 && !gameOver) {
				gameOver = true;
				GameObject gameOverText = GameObject.FindGameObjectWithTag ("GameOver");
				gameOverText.GetComponent<Animator>().SetBool("gameOver", true);
			}
			// 3 
			for (int i = 0; i < healthIndicator.Length; i++) {
				if (i < Health) {
					healthIndicator[i].SetActive(true);
				} else {
					healthIndicator[i].SetActive(false);
				}
			}
		}
	}

	IEnumerator regenMana ()
	{
		while (true) {
			if (ManageTheGame.Instance.Player.PlayerMana.CurrentMana < ManageTheGame.Instance.Player.PlayerMana.MaxMana) {
				ManageTheGame.Instance.Player.PlayerMana.CurrentMana += ManageTheGame.Instance.Player.PlayerMana.RegenMana;
				manaLabel.text = ManageTheGame.Instance.Player.PlayerMana.CurrentMana.ToString();
			}
			yield return new WaitForSeconds(1);
		}
	}

	// Use this for initialization
	void Start () {
		Gold = 50;
		Wave = 0;
		Health = 5;
		instance = this;
		ManageTheGame.Instance.Player.PlayerMana.CurrentMana = ManageTheGame.Instance.Player.PlayerMana.MaxMana;
		manaLabel.text = ManageTheGame.Instance.Player.PlayerMana.CurrentMana.ToString();
		StartCoroutine (regenMana ());
	}

}
