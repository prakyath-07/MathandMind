using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem ps,confettiPS;
    int num1,num2,score=0;
    public Text counterText,scoreText,finalscore,num1Text,num2Text,sign;
    public Button btn_option1,btn_option2,btn_option3;
    public float timerValue;
  
     //options
       public Text option1text,option2text,option3text,clicked_value;
      
       public Button myButton;

       //PANEL DATA
       public GameObject winscreen, GameOverScreen;

       //New Try (can be deleted )
        //public GameObject buttonPrefab;
   // public GameObject panelToAttachButtonsTo;

    //new try2
    public static int res;
       
    public void Start()
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
           //Time.timeScale=0;
         }
    }

    public int numberGenerator()
    {
        string[] signs = new string[] { "+", "*" };
        string randomSign = signs[Random.Range(0, signs.Length)];
        sign.text=randomSign;
        // string temp=randomSign.text;
        // int sign_val=  int.Parse(temp); 
        // randomSign.text = x;
        // Text txt = randomSign;
        // string x = txt.text;
        // sign.text = x.ToString("");

        num1 = Random.Range(0,10);
        //Debug.Log("First Number is "+num1);
        num2 = Random.Range(0,10);
        //print("Second Number is "+num2);
       // Debug.Log("Operation is "+randomSign);
        num1Text.text = num1.ToString("");
        num2Text.text = num2.ToString("");
        // res = num1 + num2;
        
         switch(randomSign)
         {
             case "+":
             res = num1+num2;
            // print("Answer should be "+res);
             break;

             case "-":
             res = num1-num2;
            // print("Answer should be"+res);
             break;

             case "*":
             res = num1*num2;
           //  print("Answer should be "+res);
             break;
         }
         return res;

    }

    public void optionGenerator()
    {
        GameObject.Find("Content").GetComponent<populatescript>().populate();
        // int temp = Random.Range(0,2);
        // print("temp no is"+temp);
        // ////option 1/////////////////////
        // if(temp ==0)
        // {
        //     int option1_value =res;
        //     option1text.text = option1_value.ToString("");
        // }
        // else{
        //     int option1_value = Random.Range(0,10);
        // option1text.text = option1_value.ToString("");
        // }
        // /////option 2/////
        // if(temp==1)
        // {
        // int option2_value =res;
        // option2text.text = option2_value.ToString("");
        // }   
        // else
        // {
        //     int option2_value = Random.Range(0,10);
        // option2text.text = option2_value.ToString("");
        // }
        
        // ///option3////////////////////////////////

        // if(temp == 2)
        //  {
        //  int option3_value =res;
        // option3text.text = option3_value.ToString("");
        //  }   
        //  else
        //  {
        //  int option3_value =Random.Range(0,10);
        //  option3text.text = option3_value.ToString("");
        //  }

      //  print("answer is"+ res);
       //Debug.Log(x);
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

    //button click function (prefab)
    

}
