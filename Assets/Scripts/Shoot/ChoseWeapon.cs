using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoseWeapon : MonoBehaviour
{

    public GameObject blaster, m60, future;

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Blaster"){
            GunChoose(true, false, false);
        }
        if(col.gameObject.tag == "M60"){
            GunChoose(false, true, false);
        }
        if(col.gameObject.tag == "Future"){
            GunChoose(false, false, true);
        }
    }

    private void GunChoose(bool b, bool m, bool f){
        blaster.SetActive(b);
        m60.SetActive(m);
        future.SetActive(f);
    }
}
