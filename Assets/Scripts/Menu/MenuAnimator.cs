using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimator : MonoBehaviour
{

	private Animator anim;

	void Start () {	
		anim = GetComponent<Animator>();
        PlayerPrefs.SetInt("Dance", 1);
	}

    public void House(){
        anim.SetTrigger("Hou");
        PlayerPrefs.SetInt("Dance", 1);
    }

    public void Macarena(){
        anim.SetTrigger("Mac");
        PlayerPrefs.SetInt("Dance", 2);
    }

    public void Hiphop(){
        anim.SetTrigger("Hip");
        PlayerPrefs.SetInt("Dance", 3);
    }
}
