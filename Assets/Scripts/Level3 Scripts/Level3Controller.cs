using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject winscreen;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Bear.locked && circle.locked && polygon.locked)
        winscreen.SetActive(true);
        print("yo yo");
    }
}
