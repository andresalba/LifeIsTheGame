using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graviton : MonoBehaviour
{
    public ScriptableBullet grv;
    bool rot = false;

    void Start()
    {
        transform.localScale += new Vector3(grv.sizeX,grv.sizeY,grv.sizeZ);
    }

    void Update()
    {
        transform.Translate(0.0f,0.0f,0.3f);
        if(rot){transform.Rotate(0.0f, 0.0f, 10.0f, Space.Self);}  
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Obj"){
            col.transform.parent = transform;//add Obj as a child
            rot = true;
        }
    }

}
