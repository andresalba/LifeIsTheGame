using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    //public CharacterController player;
    public float speed;
    private float rotation;
    Vector3 mov, posi;

    void Start()
    {
       // player = GetComponent<CharacterController>();
        speed = 3.0f;
        mov = new Vector3(0.0f, 0.0f, speed * Time.deltaTime);
        rotation = 45.0f;
    }

    void Update()
    {
        KeyMover();
        MovConstraint();
    }

    void  KeyMover(){
        if (Input.GetKey("up")){
            //Debug.Log("up");
            transform.Translate(mov);
        }
        if (Input.GetKey("down")){
            //Debug.Log("down");
            transform.Translate(-mov);
        }
        if (Input.GetKey("left")){
            //Debug.Log("left");
            transform.eulerAngles += (new Vector3(0,-rotation,0)) * Time.deltaTime;
        }
        if (Input.GetKey("right")){
            //Debug.Log("right");
            transform.eulerAngles += (new Vector3(0,rotation,0)) * Time.deltaTime;
        }
    }

    void MovConstraint(){//mantiene al personaje en el escenario
		posi = transform.position;

		if(posi.x > 20.0f){
			transform.position = new Vector3 (20.0f, posi.y, posi.z);
		}
		if(posi.x < -20.0f){
			transform.position = new Vector3 (-20.0f, posi.y, posi.z);
		}
		if(posi.z > 20.0f){
			transform.position = new Vector3 (posi.x, posi.y, 20.0f);
		}
		if(posi.z < -20.0f){
			transform.position = new Vector3 (posi.x, posi.y, -20.0f);
		}

	}
}
