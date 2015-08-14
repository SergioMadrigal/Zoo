using UnityEngine;
using System.Collections;

public class Movimient : MonoBehaviour {


	void OnMouseDown(){
	
			Vector3 temp = transform.position;
			temp.y = 250;
			transform.position = temp;
		
    }


}