using UnityEngine;
using System.Collections;

public class cubered : MonoBehaviour {

	public GameObject trCubered;
	public Transform trCubegreen;
	bool cubeclicked = false;
	bool flag = true;
	int i,j = 0;

	// Use this for initialization
	void Start () {
		aaa.arrWorld[aaa.intX,aaa.intY]=1;
	}
	
	// Update is called once per frame
	void Update () {
		// сгенерировать новые квадраты
		if (cubeclicked) {
			// сгенерировать ребенка
			Transform t = Instantiate(trCubegreen) as Transform;
			t.parent = transform;
			t.localScale = new Vector3(1,1,1);
			t.localPosition = Vector3.zero;
			t.localPosition = new Vector3(0,1.1F,0);
			t.gameObject.name = "CubeGreenX";
			flag = false;
			cubeclicked = false;
			aaa.intY=3;
			aaa.arrWorld[aaa.intX,aaa.intY]=1;
		}
	}

	void OnMouseDown() {
		if (flag) {
			cubeclicked = true;
			Debug.Log ("cubered: clicked");
		}
		else {
			foreach (Transform childTransform in transform) Destroy(childTransform.gameObject);
			flag=true;
			// обнулить массив
			for(i=0;i<=aaa.maxX;i++){
				for(j=0;j<=aaa.maxY;j++){
					aaa.arrWorld[i,j] = 0;
				}
			}
			for(i=0;i<=aaa.maxX;i++){
				for(j=0;j<=aaa.maxY;j++){
					aaa.arrWorld[i,j] = 0;
				}
			}
			// центральный квадрат
			aaa.intX = aaa.redcoordX;
			aaa.intY = aaa.redcoordY;
			aaa.arrWorld [aaa.redcoordX, aaa.redcoordY] = 1;
			//Debug.Log("cubered: already clicked");
		}
	}

	/**
	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}

	void OnMouseExit(){  
		renderer.material.color = Color.red;  
	}
	**/
}
