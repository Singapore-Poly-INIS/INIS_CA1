using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetactorManager : MonoBehaviour {

	void OnTriggerEnter(Collider col){
	
		if (col.gameObject.tag=="Oxygen") 
		{
			ValueManager.value += 7;
			Destroy(GameObject.FindWithTag("Yellow"));
		}

		if(col.gameObject.tag == "Hydrogen")
		 {
			print("Hydrogen Added");
			ValueManager.value += 1;
		}

	 if (col.gameObject.tag == "Nitrogen") 
		{
			ValueManager.value += 5;
		}

		 if (col.gameObject.tag == "Carbon")
		 {
		ValueManager.value += 6;
		print("Carbon Added");
		}

	}
	}
