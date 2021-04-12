using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public bool fireBullet;
    public GameObject bullet;

    public static Canon instance;

    void Awake(){
        instance = this;
    }

    void Start()
    {
        fireBullet = false;
    }

    void Update()
    {
        if(fireBullet){
            Instantiate(bullet, transform.position, transform.rotation);
            fireBullet = false;
        }
    }
}
