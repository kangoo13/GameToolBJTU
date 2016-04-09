using UnityEngine;
using System.Collections;

public class User : MonoBehaviour
{
	int level {
		get { return level; }
		set { level = value; }
	}
	int gold {
		get { return gold; }
		set { gold = value; }
	}
	int current_mana {
		get { return current_mana; }
		set { current_mana = value; }
	}
	int mana_max {
		get { return mana_max; }
		set { mana_max = value; }
	}


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void BuildSomething(){
	}

	void CastSpell(){
	}
}

