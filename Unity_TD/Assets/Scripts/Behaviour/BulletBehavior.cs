﻿using UnityEngine;
using System.Collections;

public class BulletBehavior : MonoBehaviour {

	public float speed = 10;
	public int damage;
	public GameObject target;
	public Vector3 startPosition;
	public Vector3 targetPosition;
	
	private float distance;
	private float startTime;
	
	private GameManagerBehavior gameManager;
	[SerializeField]
	private bool isPoison = false;
	[SerializeField]
	private bool isIce = false;
	[SerializeField]
	private bool isStun = false;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		distance = Vector3.Distance (startPosition, targetPosition);
		GameObject gm = GameObject.Find("GameManager");
		gameManager = gm.GetComponent<GameManagerBehavior>();	
	}
	
	// Update is called once per frame
	void Update () {
		// 1 
		float timeInterval = Time.time - startTime;
		gameObject.transform.position = Vector3.Lerp(startPosition, targetPosition, timeInterval * speed / distance);
		
		// 2 
		if (gameObject.transform.position.Equals(targetPosition)) {
			if (target != null) {
				// 3
				if (isIce)
					target.GetComponent<MonsterInfo> ().touchedByIce ();
				if (isPoison)
					target.GetComponent<MonsterInfo> ().touchedByPoison (damage);
				if (isStun)
					target.GetComponent<MonsterInfo> ().touchedByStun ();
				Transform healthBarTransform = target.transform.FindChild("HealthBar");
				HealthBar healthBar = 
					healthBarTransform.gameObject.GetComponent<HealthBar>();
				healthBar.removeHealth (damage);
			}
			Destroy(gameObject);
		}	
	}
}
