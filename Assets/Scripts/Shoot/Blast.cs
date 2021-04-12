using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blast : MonoBehaviour
{
    public ScriptableBullet bllt;

    void Start()
    {
        transform.localScale += new Vector3(bllt.sizeX,bllt.sizeY,bllt.sizeZ);
    }

    void Update()
    {
        transform.Translate(0f,0f,0.5f);
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Floor"){// si impacta con el piso
            Debug.Log("piso impactado");
            Destroy(gameObject);//destruya esta bala
        }
    }
}
