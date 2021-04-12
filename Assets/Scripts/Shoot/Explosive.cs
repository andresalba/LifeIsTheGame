using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosive : MonoBehaviour
{
    public ScriptableBullet expl;
    public GameObject bang;
    float delay = 0.5f;
    float timmer;

    void Start()
    {
        transform.localScale += new Vector3(expl.sizeX,expl.sizeY,expl.sizeZ);
        timmer = delay;  
    }

    void Update()
    {
        transform.Translate(0f,0f,0.5f);
        timmer -= Time.deltaTime;
        if( timmer <= 0f ){
            Explosion();
        }
    }

    void Explosion(){
        Instantiate(bang, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
