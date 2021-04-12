using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{

    public GameObject canon1, canon2, canon3;
    bool ready = false;

    void Update()
    {
        if(canon1.activeInHierarchy || canon2.activeInHierarchy || canon3.activeInHierarchy){//avoid the setactive error
            ready = true;
        }
        if (Input.GetKeyDown("z") && ready){
            Canon.instance.fireBullet = true;
        }
    }
}
