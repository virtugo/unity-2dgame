using UnityEngine;
using System.Collections;

public class aaa : MonoBehaviour {

	public static bool cubeclicked = false; // на кубик не нажимали
	public static bool cubechecked = false; // кубик не выбран
	//bool flag = false; // вспомогательный флаг

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (cubeclicked) {
			cubechecked = !cubechecked;
			cubeclicked = false;
			Debug.Log("aaa: cubeclicked = true");
		}
		if (cubechecked) { // показываем меню
			// один раз
			// показываем меню

		}
	}
}
