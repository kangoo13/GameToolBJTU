using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelSelection : MonoBehaviour {
	
	public LevelSelection(int level, Sprite sprite) {

		GameObject levelObject = (GameObject)Instantiate (Resources.Load ("Level"));

	}

/*	public LevelObject CurrentLevel {

		get {
			return currentLevel;
		} set {
			currentLevel = value;
			int currentLevelIndex = levels.IndexOf(currentLevel);

			GameObject levelVisualization = levels[currentLevelIndex].visualization;
			for (int i = 0; i < levels.Count; i++) {
				if (levelVisualization != null) {
					if (i == currentLevelIndex) {
						levels[i].visualization.SetActive(true);
					} else {
						levels[i].visualization.SetActive(false);
					}
				}
			}
		}
	}*/


}
