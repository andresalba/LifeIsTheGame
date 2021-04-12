using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
class Explosion: Creates the explotion in the indicated place
Created by: Andres Alba
Date: January 2021 
*/

public class Explosion : MonoBehaviour
{
    AudioSource m_MyAudioSource;
    float del = 1.8f;
    float timer;

    void Start()
    {
        timer = del;  
        m_MyAudioSource = GetComponent<AudioSource>();   
        m_MyAudioSource.Play();    
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if( timer <= 0f){      
            Destroy(gameObject);
        }
         
    }
}
