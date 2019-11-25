using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compounds : MonoBehaviour
{
public int count_H=0;
public int count_O=0;
public int count_N=0;
public int count_C=0;

public GameObject hydrogen;

private void OnTriggerEnter(Collider col){
if(col.gameObject.name == "Centre_H"){
    count_H++ ;
    GameObject o = Instantiate(hydrogen,transform.position + new Vector3(1,0,0), transform.rotation);
     Debug.Log("Hydrogen added");

}

else if (col.gameObject.name == "Centre_N"){
    count_N++;
    
      Debug.Log("Nitrogen added");

}

else if (col.gameObject.name == "Centre_O"){
count_O++;
 Debug.Log("Oxygen added");
}

else if (col.gameObject.name == "Centre_C"){
    count_C++;
 Debug.Log("Carbon added");
}
    }

}
