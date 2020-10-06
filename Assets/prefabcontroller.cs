using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class prefabcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    //public Button yourButton;
    void Start()
    {
        // Button btn = yourButton.GetComponent<Button>();
        // btn.onClick.AddListener(btn_Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_Click()
    {
        //int x;
        int res = GameObject.Find("GameController").GetComponent<GameManager>().numberGenerator();
        //print("prefab clicked ans is "+res);
        
         string name =  EventSystem.current.currentSelectedGameObject.name;
        Text txt = GameObject.Find(name).GetComponentInChildren<Text>();
        //txt.text = txt.ToString("");
        
        string x=txt.text;
        int selected_val=  int.Parse(x);
        print("text on selected prefab is"+ selected_val);
       // print(selected_val);
        //print(txt.text);
        if(selected_val==res)
        {
            //AudioManager.play_crctSFX();
           GameObject.Find("AudioManager").GetComponent<AudioManager>().play_crctSFX();
            //AudioSource.PlayClipAtPoint(correctAnsSound,Camera.main.transform.position,0.75f);
            GameObject.Find("GameController").GetComponent<GameManager>().Score_Up();
           // print("you gave correct ans!");
            //

        }
        else
        {
            GameObject.Find("CameraShake").GetComponent<CameraShakeScript>().ShakeIt();
            GameObject.Find("SecAudioManager").GetComponent<SecAudioManager>().play_wrongSFX();
            if( health_manager.health ==00f)
             GameObject.Find("GameController").GetComponent<GameManager>().gameOver();
            health_manager.health -=10f;
           // print("you gave wrong ans");
        //     if(WrongPanel!=null)
        //   WrongPanel.SetActive(true);
        }
        GameObject.Find("GameController").GetComponent<GameManager>().Start();
      //  GameObject.Find("Content").GetComponent<populatescript>().Start();
        
    }
    public void test()
    {
        print("*");
    }
    
}
