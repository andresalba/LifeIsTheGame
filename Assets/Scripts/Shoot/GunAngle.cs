using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAngle : MonoBehaviour
{
    public ScritableAngle ang;

    void Start()
    {
        transform.Rotate(ang.angleX, 0.0f, 0.0f, Space.Self);        
    }

}
