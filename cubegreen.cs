using UnityEngine;
using System.Collections;

public class cubegreen1 : MonoBehaviour {

	public Transform trCubegreen;
	bool cubeclicked = false;
	bool flag = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		// сгенерировать новые квадраты
		if (cubeclicked) {
			// сгенерировать ребенка
			Transform t = Instantiate(trCubegreen) as Transform;
			t.parent = transform;
			t.localPosition = Vector3.zero;
			t.localPosition = new Vector3(0,1,0);
			t.gameObject.name = "CubeGreenX";
			flag = false;
			cubeclicked = false;
		}
	}

	void OnMouseDown() {
		if (flag) {
			cubeclicked = true;
			Debug.Log ("cubegreenX: clicked");
		}
		else Debug.Log("cubegreenX: already clicked");
	}

	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}
	
	void OnMouseExit(){  
		renderer.material.color = Color.green;  
	} 
}
