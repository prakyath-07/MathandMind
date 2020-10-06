using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class screen_load : MonoBehaviour
{
    // Start is called before the first frame update
    Image loadbar;
       public float maxload = 100f;
       public static float load;
    void Start()
    {
         loadbar = GetComponent<Image>();
        //load = maxload;
        InvokeRepeating("loader", 0f, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
          loadbar.fillAmount = load/maxload;
           //load +=10f;
    }

    public void loader()
    {
        if(load != 100f)
        load +=10f;
        else
        {
         CancelInvoke("loader");
         SceneManager.LoadScene("HomePage");
        }
    }
}
