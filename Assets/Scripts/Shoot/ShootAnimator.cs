using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAnimator : MonoBehaviour
{
	private Animator anim;
    private int style;

	void Start () {	
		anim = GetComponent<Animator>();
        style = PlayerPrefs.GetInt("Dance");
        SelectStyle();
	}

    private void SelectStyle(){
        switch (style)
        {
            case 1:
                anim.SetTrigger("Hou");
                //Debug.Log("House selected");
                break;
            case 2:
                anim.SetTrigger("Mac");
                //Debug.Log("Macarena selected");
                break;
            case 3:
                anim.SetTrigger("Hip");
                //Debug.Log("Hiphop selected");
                break;
            default:
                Debug.Log("error in animator");
                break;
        }
    }
}
