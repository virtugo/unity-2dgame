using UnityEngine;
using System.Collections;

public class cubegreen1 : MonoBehaviour {

	public Transform trCubegreen;
	bool cubeclicked = false;
	bool flag = true;
	bool flag2 = false;
	float a = 0;
	int i = 0;

	// Use this for initialization
	void Start () {
		Random.seed = (int)System.DateTime.Now.Ticks;
		//if((aaa.intX>0)&&(aaa.intX<19)&&(aaa.intY>0)&&(aaa.intY<8)){
		//}
		do{
			a = Random.Range (1,5);

			if (a==1){
				if(aaa.intY>0){
					if(aaa.arrWorld[aaa.intX,aaa.intY-1]==0)flag2 = true;
				}
			}
			else if (a==3){
				if(aaa.intY<aaa.maxY){
					if(aaa.arrWorld[aaa.intX,aaa.intY+1]==0)flag2 = true;
				}
			}
			else if (a==2){
				if(aaa.intX<aaa.maxX){
					if(aaa.arrWorld[aaa.intX+1,aaa.intY]==0)flag2 = true;
				}
			}
			else if (a==4){
				if(aaa.intX>0){
					if(aaa.arrWorld[aaa.intX-1,aaa.intY]==0)flag2 = true;
				}
			}
			i++;
			// обработка тупика, иначе зависнет
			if(i==100)Debug.Log("cubegreen: random failed");
		}while((!flag2)&&(i<100));
		//Debug.Log ("random: " + a);
	}
	
	// Update is called once per frame
	void Update () {
		// сгенерировать новые квадраты
		if (flag2){
			if (cubeclicked) {
				Transform t = Instantiate(trCubegreen) as Transform;
				t.parent = transform;
				// сгенерировать ребенка
				if (a==1){
					aaa.intY--;
					t.localPosition = new Vector3(0,1.1F,0);
				}
				else if(a==2){
					aaa.intX++;
					t.localPosition = new Vector3(1.1F,0,0);
				}
				else if(a==3){
					aaa.intY++;
					t.localPosition = new Vector3(0,-1.1F,0);
				}
				else if(a==4){
					aaa.intX--;
					t.localPosition = new Vector3(-1.1F,0,0);
				}
				t.gameObject.name = "CubeGreenX";
				flag = false;
				cubeclicked = false;
				Debug.Log ("x=" + aaa.intX + ", y=" + aaa.intY);
				aaa.arrWorld[aaa.intX,aaa.intY]=1;
			}
		}
	}

	void OnMouseDown() {
		if (flag) {
			cubeclicked = true;
			//Debug.Log ("cubegreen: clicked");
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
