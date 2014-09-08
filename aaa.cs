using UnityEngine;
using System.Collections;

public class aaa : MonoBehaviour {

	public static int redcoordX = 7;
	public static int redcoordY = 4;

	public static int[,] arrWorld;
	public static int intX = redcoordX;
	public static int intY = redcoordY;
	public static int maxX = 14;
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
		// координата красного
		arrWorld [redcoordX, redcoordY] = 1;
		//Debug.Log (arrWorld[0,0]);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
