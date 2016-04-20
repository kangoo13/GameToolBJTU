using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
	public String title;
	public String levelName;
	public String sceneName;


	public void UpdateText() {
		transform.GetChild (0).GetComponent<Text> ().text = title;
		transform.GetChild (1).GetComponent<Text> ().text = levelName;
	}

	// Use this for initialization
	void Start ()
	{
	//	levelObject = (GameObject)Resources.Load ("Prefabs/Menu/Level1", GameObject) as GameObject;
	//	levelObject.GetComponent<Text> ().text = sceneName;
		RectTransform rt = transform.GetComponent<RectTransform>();
		rt.sizeDelta = new Vector2 ( transform.GetComponent<Image>().rectTransform.rect.width, transform.GetComponent<Image>().rectTransform.rect.height);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	public void OnSelectedScene() {
		SceneManager.LoadScene (sceneName);	
//		SceneManager.LoadScene (1);	
	}
}

