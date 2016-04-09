using UnityEngine;
using System.Collections;

abstract class Button : MonoBehaviour
{
	string btn_name {
		get { return btn_name; }
		set { btn_name = value; }
	}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnSelected(string scene){
		GameManager.Instance.LoadScene (scene);
	}
}

