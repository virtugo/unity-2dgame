using UnityEngine;
using System.Collections;

public class cubegreen1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown() {
		Debug.Log("cubegreen: clicked");
	}

	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}
	
	void OnMouseExit(){  
		renderer.material.color = Color.green;  
	} 
}
