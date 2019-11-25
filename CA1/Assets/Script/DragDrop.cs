using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DragDrop : MonoBehaviour
{
[SerializeField] public  GameObject Hydrogen;
[SerializeField] public  GameObject Element2;
[SerializeField] public  GameObject Element3;
[SerializeField] public  GameObject Element4;

public int count_H=0;
public int count_O=0;
public int count_N=0;
public int count_C=0;

private void OnCollisionEnter(Collision col){
if(col.gameObject.tag == "Hydrogen"){
    count_H++ ;
   /*  GameObject o = Instantiate(Hydrogen,transform.position + new Vector3(1,0,0), transform.rotation); */
    /* o.transform.setParent("Oxygen"); */
     Debug.Log("Hydrogen added");

}

 else if (col.gameObject.tag == "Nitrogen"){
    count_N++;
      Debug.Log("Nitrogen added");

}

 else if (col.gameObject.tag == "Oxygen"){
count_O++;

}

else if (col.gameObject.tag == "Carbon"){
    count_C++;

}
    }

}

     /* private void onTriggerExit(Collider other){
        count_H=0;
        count_N=0;
        count_O=1;
        count_C=0;
    } */
