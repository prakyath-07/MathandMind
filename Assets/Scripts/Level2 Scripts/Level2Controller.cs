using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Controller : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform[] pictures;
    private GameObject wintext;
    public static bool youwin;
    public GameObject winscreen;
    public ParticleSystem confettiPS2,confettiPS;
    void Start()
    {
        youwin = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(pictures[0].rotation.z == 0 &&
        pictures[1].rotation.z == 0 &&
        pictures[2].rotation.z == 0 &&
        pictures[3].rotation.z == 0 &&
        pictures[4].rotation.z == 0 &&
        pictures[5].rotation.z == 0 )
       {
           youwin = true;
            confettiPS.Play ();
             confettiPS2.Play ();
           winscreen.SetActive(true);   
           print("yo boi");
       }
    }
}
