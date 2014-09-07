using UnityEngine;
using System.Collections;

public class cubegreen1 : MonoBehaviour {

	public Transform trCubegreen;
	bool cubeclicked = false;
	bool flag = true;
	bool flag2 = false;
	float a = 0;

	// Use this for initialization
	void Start () {
		Random.seed = (int)System.DateTime.Now.Ticks;
		// добавить обработку тупика, иначе зависнет
		do{
			a = Random.Range (1,5);

			if (a==1){
				if(aaa.intY>0){
					if(aaa.arrWorld[aaa.intX,aaa.intY-1]==0)flag2 = true;
				}
			}
			else if (a==3){
				if(aaa.intY<8){
					if(aaa.arrWorld[aaa.intX,aaa.intY+1]==0)flag2 = true;
				}
			}
			else if (a==2){
				if(aaa.intX<19){
					if(aaa.arrWorld[aaa.intX+1,aaa.intY]==0) flag2 = true;
				}
			}
			else if (a==4){
				if(aaa.intX>0){
					if(aaa.arrWorld[aaa.intX-1,aaa.intY]==0) flag2 = true;
				}
			}
		}while(!flag2);
		Debug.Log ("random: " + a);
	}
	
	// Update is called once per frame
	void Update () {
		// сгенерировать новые квадраты
		if (cubeclicked) {
			// сгенерировать ребенка
			if (a==1){
				aaa.intY--;
				Transform t = Instantiate(trCubegreen) as Transform;
				t.parent = transform;
				t.localScale = new Vector3(1,1,1);
				t.localPosition = new Vector3(0,1.1F,0);
				t.gameObject.name = "CubeGreenX";
				flag = false;
				cubeclicked = false;
			}
			else if(a==2){
				aaa.intX++;
				Transform t = Instantiate(trCubegreen) as Transform;
				t.parent = transform;
				t.localPosition = Vector3.zero;
				t.localPosition = new Vector3(1.1F,0,0);
				t.gameObject.name = "CubeGreenX";
				flag = false;
				cubeclicked = false;
			}
			else if(a==3){
				aaa.intY++;
				Transform t = Instantiate(trCubegreen) as Transform;
				t.parent = transform;
				t.localPosition = Vector3.zero;
				t.localPosition = new Vector3(0,-1.1F,0);
				t.gameObject.name = "CubeGreenX";
				flag = false;
				cubeclicked = false;
			}
			else if(a==4){
				aaa.intX--;
				Transform t = Instantiate(trCubegreen) as Transform;
				t.parent = transform;
				t.localPosition = Vector3.zero;
				t.localPosition = new Vector3(-1.1F,0,0);
				t.gameObject.name = "CubeGreenX";
				flag = false;
				cubeclicked = false;
			}
			Debug.Log ("x=" + aaa.intX + ", y=" + aaa.intY);
			aaa.arrWorld[aaa.intX,aaa.intY]=1;
		}
	}

	void OnMouseDown() {
		if (flag) {
			cubeclicked = true;
			Debug.Log ("cubegreen: clicked");
		}
		else Debug.Log("cubegreen: already clicked");
	}

	void OnMouseEnter(){  
		renderer.material.color = Color.grey;  
	}
	
	void OnMouseExit(){  
		renderer.material.color = Color.green;  
	} 
}
