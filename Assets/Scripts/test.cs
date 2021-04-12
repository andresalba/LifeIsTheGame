using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Class just for test not used in the game*/

public class test : MonoBehaviour
{

    public GameObject rotator; 

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){// si impacta el player
            Debug.Log("Player detected");
        }
    }

    void Update(){
        Orbiter();
    }

    private void Orbiter(){
        transform.RotateAround(rotator.transform.position, Vector3.forward, 100 * Time.deltaTime);
    }
}
