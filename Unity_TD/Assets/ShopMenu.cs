using UnityEngine;
using System.Collections;

public class ShopMenu : MonoBehaviour {

	public GameObject topMenuObj;

	public void displayShop()
	{
		topMenuObj.GetComponent<TopMainMenuHandle> ().displayShop ();
	}
}
