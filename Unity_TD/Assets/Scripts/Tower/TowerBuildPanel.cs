using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TowerBuildPanel : MonoBehaviour {
	[SerializeField]
	GameObject[] towersPrefabs;
	[SerializeField]
	GameObject imagePrefab;
	// Use this for initialization

	public void Initialize(RadialBuild radialObj)
	{
		int loop = 0;
		foreach (GameObject tower in towersPrefabs)
		{
			GameObject TowerImage = Instantiate (imagePrefab) as GameObject;
			TowerImage.GetComponent<TowerBuildSelected> ().Reference = radialObj;
			TowerImage.transform.SetParent (this.transform, false);
			RectTransform rect = TowerImage.GetComponent<RectTransform> ();
			double dividend = loop / 2;
			int intDividend = loop / 2;
			if (dividend > 1)
				rect.localPosition = new Vector3 (rect.localPosition.x, rect.localPosition.y - 55 * intDividend, rect.localPosition.z);
			TowerImage.GetComponent<TowerBuildSelected> ().setTowerImage (tower);
			if (loop % 2 == 0)
				rect.localPosition = new Vector3 (65, rect.localPosition.y, rect.localPosition.z);
			else
				rect.localPosition = new Vector3 (-65, rect.localPosition.y, rect.localPosition.z);
			loop++;
		}
	}

}
