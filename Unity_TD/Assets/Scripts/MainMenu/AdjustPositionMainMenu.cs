using UnityEngine;
using System.Collections;

public class AdjustPositionMainMenu : MonoBehaviour {
	Vector2 topPos;
	// Use this for initialization
	void Start () {
		Vector2 thisPos = GetComponent<RectTransform> ().sizeDelta;
		RectTransform topRt = GameObject.Find("Canvas/TopPanel").GetComponent<RectTransform>();
		topRt.sizeDelta = new Vector2 (thisPos.x / 1.34952662722f, thisPos.y/1.72f);
		topPos = topRt.sizeDelta;
		RectTransform botRt = GameObject.Find ("Canvas/BottomPanel").GetComponent<RectTransform> ();
		botRt.sizeDelta = new Vector2 (topRt.sizeDelta.x, thisPos.y / 2.99130434783f);
		botRt.anchoredPosition = new Vector2 (0, thisPos.y / 22.9333333333f);

		RectTransform shopRt = GameObject.Find ("Canvas/BottomPanel/shopButton").GetComponent<RectTransform> ();
		shopRt.sizeDelta = new Vector2 (thisPos.x/7.69411764706f, thisPos.y / 4.52631578947f);			

		RectTransform currentRt = GameObject.Find ("Canvas/BottomPanel/currentLevel").GetComponent<RectTransform> ();
		currentRt.sizeDelta = new Vector2 (thisPos.x/5.45f, thisPos.y / 9.82857142857f);
		currentRt.anchoredPosition = new Vector2 (thisPos.x / -4.36f, 0f);

		RectTransform nextRt = GameObject.Find ("Canvas/BottomPanel/nextLevel").GetComponent<RectTransform> ();
		nextRt.sizeDelta = new Vector2 (thisPos.x/5.45f, thisPos.y / 9.82857142857f);
		nextRt.anchoredPosition = new Vector2 (thisPos.x / 3.44210526316f, 0f);

		RectTransform sliderRt = GameObject.Find ("Canvas/BottomPanel/ExpSlider").GetComponent<RectTransform> ();
		sliderRt.sizeDelta = new Vector2 (thisPos.x/2.88105726872f, thisPos.y / 9.82857142857f);

	}

	public void adjustTopMenu() {
		Vector2 thisPos = GetComponent<RectTransform> ().sizeDelta;

		/* Get level select object */
		RectTransform levelSelectRt = transform.GetChild(0).GetChild(0).gameObject.GetComponent<RectTransform> ();
		levelSelectRt.sizeDelta = new Vector2 (thisPos.x / 9.08333333333f, thisPos.y/12.2857142857f);
		levelSelectRt.anchoredPosition = new Vector2(0f, thisPos.y / 5.93103448276f);

		/* Get Scroll View Object */
		RectTransform scrollViewRt = transform.GetChild(0).GetChild(1).gameObject.GetComponent<RectTransform>();
		scrollViewRt.anchoredPosition = new Vector2 (0f, thisPos.y / -8f);
		scrollViewRt.sizeDelta = new Vector2 (topPos.x, thisPos.y / 2.86666666667f);

	}

}
