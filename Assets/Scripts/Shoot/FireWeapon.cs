using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireWeapon : MonoBehaviour
{

    void Update()
    {
       if (Input.GetKeyDown("f")){
           Canon.instance.fireBullet = true;
       }
    }
}
