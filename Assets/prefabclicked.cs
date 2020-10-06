using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class prefabclicked : MonoBehaviour
{
    //This function is called when the prefab is clicked
    //This is used to compare the selected answer with the correct result
     public void btn_Click()
    {
        int thisres = GameManager.res;
        print("result from btn click page "+ thisres);
        
         //string name =  EventSystem.current.currentSelectedGameObject.name;
        Text txt = this.gameObject.GetComponentInChildren<Text>();
        //txt.text = txt.ToString("");
        
        string x=txt.text;
        int selected_val=  int.Parse(x);
        print("text on selected prefab is "+ selected_val);
       // print(selected_val);
        //print(txt.text);
        if(selected_val==thisres)
        {
            print("yes reaching till here");
            //AudioManager.play_crctSFX();
           GameObject.Find("AudioManager").GetComponent<AudioManager>().play_crctSFX();
            //AudioSource.PlayClipAtPoint(correctAnsSound,Camera.main.transform.position,0.75f);
            GameObject.Find("GameController").GetComponent<GameManager>().Score_Up();
           // print("you gave correct ans!");
             print("reach aapundu, something wrong?");
            //

        }
        else
        {
            
            GameObject.Find("CameraShake").GetComponent<CameraShakeScript>().ShakeIt();
            GameObject.Find("SecAudioManager").GetComponent<SecAudioManager>().play_wrongSFX();
            if( health_manager.health ==10f)
             GameObject.Find("GameController").GetComponent<GameManager>().gameOver();
            health_manager.health -=10f;
           // print("you gave wrong ans");
        //     if(WrongPanel!=null)
        //   WrongPanel.SetActive(true);
        }
        GameObject.Find("GameController").GetComponent<GameManager>().Start();
      //  GameObject.Find("Content").GetComponent<populatescript>().Start();
        
    }

}
