using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
   // public AudioClip correctAnsSFX;
    public AudioSource src;
   
    
    public void play_crctSFX()
    {
        print("audio played!");
       src.Play();
    }
   
}
