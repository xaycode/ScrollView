using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Praktikum03 : MonoBehaviour
{
	public bool isButton1;
	public bool isButton2;
	public bool isButton3;

	GameObject view1;
	GameObject view2;
	GameObject view3;

	void Start ()
	{
		view1 = GameObject.Find ("ScrollView1");
		view2 = GameObject.Find ("ScrollView2");
		view3 = GameObject.Find ("ScrollView3");
	}



	public void diKlik ()
	{
		if (isButton1) {
			view1.SetActive (true);
			view2.SetActive (false);
			view3.SetActive (false);
		}
		if (isButton2) {
			view1.SetActive (false);
			view2.SetActive (true);
			view3.SetActive (false);
		}
		if (isButton3) {
			view1.SetActive (false);
			view2.SetActive (false);
			view3.SetActive (true);
		}
	}


}
