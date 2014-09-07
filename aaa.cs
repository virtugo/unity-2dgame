using UnityEngine;
using System.Collections;

public class aaa : MonoBehaviour {

	public static int[,] arrWorld;
	public static int intX = 10;
	public static int intY = 10;
	int i=0;
	int j=0;

	// Use this for initialization
	void Start () {
		arrWorld = new int[20,20];
		// обнуляем массив
		for(i=0;i<20;i++){
			for(j=0;j<20;j++){
				arrWorld[i,j] = 0;
			}
		}
		Debug.Log (arrWorld[0,0]);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
