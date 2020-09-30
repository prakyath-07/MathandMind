using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ps,confettiPS;
    int num1,num2,res,score=0;
    public Text counterText,scoreText,finalscore,num1Text,num2Text,sign;
    public Button btn_option1,btn_option2,btn_option3;
    public float timerValue;
     //public GameObject aObject;
    
     //options
       public Text option1text,option2text,option3text,clicked_value;
      
       public Button myButton;

       //PANEL DATA
       public GameObject winscreen, GameOverScreen;
       
    void Start()
    {
      
        //ParticleSystem ps = GetComponent<ParticleSystem>();
        ps.Play ();
        option1text = btn_option1.GetComponentInChildren<Text>();
        option2text = btn_option2.GetComponentInChildren<Text>();
        option3text = btn_option3.GetComponentInChildren<Text>();
        numberGenerator();
        optionGenerator();
       
    }

    // Update is called once per frame
    void Update()
    {
        
          timerValue-=1*Time.deltaTime;
           
         counterText.text=timerValue.ToString("00");
         if(timerValue<0)
         {
           gameOver();
         }
    }

    public void numberGenerator()
    {
        string[] signs = new string[] { "+", "-", "*" };
        string randomSign = signs[Random.Range(0, signs.Length)];
        sign.text=randomSign;
        // string temp=randomSign.text;
        // int sign_val=  int.Parse(temp); 
        // randomSign.text = x;
        // Text txt = randomSign;
        // string x = txt.text;
        // sign.text = x.ToString("");

        num1 = Random.Range(0,10);
        Debug.Log("First Number is "+num1);
        num2 = Random.Range(5,12);
        Debug.Log("Second Number is "+num2);
        Debug.Log("Operation is "+randomSign);
        num1Text.text = num1.ToString("");
        num2Text.text = num2.ToString("");
        // res = num1 + num2;
        
         switch(randomSign)
         {
             case "+":
             res = num1+num2;
             print("Correct answer is "+res);
             break;

             case "-":
             res = num1-num2;
             print("Correct answer is "+res);
             break;

             case "*":
             res = num1*num2;
             print("Correct answer is "+res);
             break;
         }

    }

    public void optionGenerator()
    {
        int option1_value = Random.Range(0,10);
        option1text.text = option1_value.ToString("");

        int option2_value = Random.Range(0,10);
        option2text.text = option2_value.ToString("");

        int option3_value = res;
        option3text.text = option3_value.ToString("");

        print("answer is"+ res);
       //Debug.Log(x);
    }
    public void btn_Click()
    {
        //int x;
         string name =  EventSystem.current.currentSelectedGameObject.name;
        // Text txt = transform.Find("Text").GetComponentInChildren<Text>();
        // print(txt);
        Text txt = GameObject.Find(name).GetComponentInChildren<Text>();
        //txt.text = txt.ToString("");
        
        string x=txt.text;
       int selected_val=  int.Parse(x);
        print("selected option is"+ selected_val);
       // print(selected_val);
        //print(txt.text);
        if(selected_val==res)
        {
            //AudioManager.play_crctSFX();
           GameObject.Find("AudioManager").GetComponent<AudioManager>().play_crctSFX();
            //AudioSource.PlayClipAtPoint(correctAnsSound,Camera.main.transform.position,0.75f);
            Score_Up();
            print("you gave correct ans!");
            //

        }
        else
        {
            GameObject.Find("CameraShake").GetComponent<CameraShakeScript>().ShakeIt();
            GameObject.Find("SecAudioManager").GetComponent<SecAudioManager>().play_wrongSFX();
            if( health_manager.health ==00f)
            gameOver();
            health_manager.health -=10f;
            print("you gave wrong ans");
        //     if(WrongPanel!=null)
        //   WrongPanel.SetActive(true);
        }
        Start();
    }
    
    ///function to handle game score
    public void Score_Up()
    {
        if(score==80)
        {
             resultScreen();
            print("you scored 80!");
        }
        else{
        score+=10;
        scoreText.text=score.ToString("00");
        }
    }
    public void gameOver()
    {
            GameOverScreen.SetActive(true);
             finalscore.text=score.ToString("00");
    }

    public void resultScreen()
    {
        //if(CorrectPanel!=null)
        winscreen.SetActive(true);
        confettiPS.Play ();
       //ps.enableEmission = false;
        finalscore.text=score.ToString("00");
       // Time.timeScale = 0;
    }

}
