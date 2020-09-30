using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecAudioManager : MonoBehaviour
{
    // Start is called before the first frame update
     public AudioSource wrongSound;   
     public void play_wrongSFX()
    {
        print("wrong audio played!");
       wrongSound.Play();
    }
}
