using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmusic_controller : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource bgmSound;   
    void Start()
    {
        bgmSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
