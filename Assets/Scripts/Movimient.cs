using UnityEngine;
using System.Collections;

public class Movimient : MonoBehaviour {

	public bool presionado;

	Vector3 nuevo;

	void Start(){
		nuevo = transform.position;
	}
	void OnMouseDown(){
		if(presionado){
			presionado = false;
			transform.position = nuevo;
		}else{
			presionado = true;
			Vector3 temp = transform.position + transform.up*60;
			transform.position = temp;
		}
    }
}