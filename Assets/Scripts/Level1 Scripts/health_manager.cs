using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class health_manager : MonoBehaviour
{
    // Start is called before the first frame update
    Image healthbar;
       public float maxhealth = 100f;
       public static float health;
       
    void Start()
    {
         healthbar = GetComponent<Image>();
        health = maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.fillAmount = health/maxhealth;
    }
}
