using UnityEngine;
using System.Collections;

public class AdjustPositionMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		RectTransform thisRt = GetComponent<RectTransform> ();
		Vector2 thisPos = thisRt.sizeDelta;
		RectTransform topRt = GameObject.Find("Canvas/TopPanel").GetComponent<RectTransform>();
		topRt.sizeDelta = new Vector2 (thisPos.x / 1.21787709497f, thisPos.y/1.376f);

		RectTransform levelSelectRt = GameObject.Find ("Canvas/TopPanel/levelSelect").GetComponent<RectTransform> ();
		levelSelectRt.sizeDelta = new Vector2 (thisPos.x / 9.08333333333f, thisPos.y/12.2857142857f);
		levelSelectRt.anchoredPosition = new Vector2(0f, thisPos.y / 4f);


		RectTransform scrollViewRt = GameObject.Find("Canvas/TopPanel/Scroll View").GetComponent<RectTransform>();
		scrollViewRt.anchoredPosition = new Vector2 (0f, thisPos.y / -19.1111111111f);
		scrollViewRt.sizeDelta = new Vector2 (topRt.sizeDelta.x, thisPos.y / 2.86666666667f);

		RectTransform botRt = GameObject.Find ("Canvas/BottomPanel").GetComponent<RectTransform> ();
		//botRt.sizeDelta = new Vector2 (topRt.sizeDelta.x, thisPos.y / 4.52631578947f);
	}

}
