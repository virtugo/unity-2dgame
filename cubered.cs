using UnityEngine;
using System.Collections;

public class cubered : MonoBehaviour {
	
	public Transform trCubegreen;
	bool flag = false;

	// Use this for initialization
	void Start () {
		Transform t = Instantiate(trCubegreen) as Transform;
		t.parent = transform;
		t.localPosition = Vector3.zero;
		t.localPosition = new Vector3(0,1,0);
		t.gameObject.name = "CubeGreenX";
	}
	
	// Update is called once per frame
	void Update () {
		// сгенерировать новые квадраты
		if (flag){
			if (aaa.cubechecked) {
				// включить детишек
			}
			flag = false;
		}
	}

	void OnMouseDown() {
		Debug.Log("cubered: mouse down");
		aaa.cubeclicked = true;
		flag = true;
	}

	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}

	void OnMouseExit(){  
		renderer.material.color = Color.red;  
	}  
}
