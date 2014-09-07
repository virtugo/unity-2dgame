using UnityEngine;
using System.Collections;

public class cubered : MonoBehaviour {
	
	public Transform trCubegreen;
	bool cubeclicked = false;
	bool flag = true;

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
			aaa.intX=10;
			aaa.intY=3;
			aaa.arrWorld[aaa.intX,aaa.intY]=1;
		}
	}

	void OnMouseDown() {
		if (flag) {
			cubeclicked = true;
			Debug.Log ("cubered: clicked");
		}
		else Debug.Log("cubered: already clicked");
	}

	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}

	void OnMouseExit(){  
		renderer.material.color = Color.red;  
	}  
}
