using UnityEngine;
using System.Collections;

public class aaa : MonoBehaviour {

	public static int[,] arrWorld;
	public static int intX = 10;
	public static int intY = 4;
	public static int maxX = 19;
	public static int maxY = 8;
	int i=0;
	int j=0;

	// Use this for initialization
	void Start () {
		arrWorld = new int[(maxX+1),(maxY+1)];
		// обнуляем массив
		for(i=0;i<=maxX;i++){
			for(j=0;j<=maxY;j++){
				arrWorld[i,j] = 0;
			}
		}
		Debug.Log (arrWorld[0,0]);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
