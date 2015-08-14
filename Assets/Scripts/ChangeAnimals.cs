using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ChangeAnimals : MonoBehaviour {

	public GameObject gameObject;
	public GameObject gameObjectTucan;
	public GameObject gameObjectViper;

	public void Start(){
		gameObject.SetActive (false);
		gameObjectTucan.SetActive (false);
		gameObjectViper.SetActive (false);
	}
	public void AnimalTiger(int TigerTo){
	
		gameObject.SetActive (true);
		Debug.Log ("Activo");

	}
	public void AnimalTucan(int TigerTo){
		
		gameObjectTucan.SetActive (true);
		Debug.Log ("Activo");
	}
	public void AnimalViper(int ViperTo){
		
		gameObjectViper.SetActive (true);
		Debug.Log ("Activo");
	}
}
