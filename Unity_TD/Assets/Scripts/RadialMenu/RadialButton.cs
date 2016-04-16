using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

//Add this to your Button Prefab
public class RadialButton : MonoBehaviour  {

	public RadialMenu myMenu;	//links back to radial menu
	public float speed = 8f;	//animation speed
	private InteractableTower obj = null;

	public InteractableTower Obj {
		get {
			return obj;
		}
		set {
			obj = value;
		}
	}

	Color defaultColor;			//used to track color of icon

	public void Anim(){
		StartCoroutine(AnimateButtonIn());
	}

	//make button grow on screen
	IEnumerator AnimateButtonIn(){
		transform.localScale = Vector3.zero;
		float timer = 0f;
		while (timer < (1 / speed)){
			timer += Time.deltaTime;
			transform.localScale = Vector3.one * timer * speed;
			yield return null;
		}
		transform.localScale = Vector3.one;
	}
		



}
