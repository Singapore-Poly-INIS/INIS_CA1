using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueManager : MonoBehaviour {
	public GameObject element;   
	public GameObject Oxygen;
	public GameObject Hydrogen;
	public GameObject Carbon;
	public GameObject Nitrogen;
	public GameObject HO;
	public GameObject Hydrogen2;
	public static int value = 0;

	void Start () {
		element.SetActive(true);
		Hydrogen.SetActive (false);
		Carbon.SetActive (false);
		Nitrogen.SetActive (false);
		Oxygen.SetActive (false);
	}
	
	void Update () {

		if (value == 1) {
			element.SetActive (false);
			Hydrogen.SetActive (true);
			value = 0;
		}

		if (value == 7) {
			Oxygen.SetActive (true);
			element.SetActive (false);
		}

		if (value == 6) {
			Carbon.SetActive (true);
			element.SetActive (false);
		}
		if (value==8){
			HO.SetActive(true);
			element.SetActive(false);
			Hydrogen.SetActive(false);
			Oxygen.SetActive(false);			
		}
	if(value==2){
			Hydrogen2.SetActive(true);
			element.SetActive(false);
			
		} 
	}
}
