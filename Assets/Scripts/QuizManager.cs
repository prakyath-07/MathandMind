using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    //private Question[] questions = new Question[3];
  public Text question ;
  public InputField answer;
  private int selection;
  
 /*void Start(){
 
      questions [0] = new Question ();
      questions [0].question = "What is 10+10";
      questions [0].correctAnswer = "20";
 
      questions [1] = new Question ();
      questions [1].question = "What is 20+20";
      questions [1].correctAnswer = "40";
 
      questions [2] = new Question ();
      questions [2].question = "What is 30+30";
      questions [2].correctAnswer = "60";
 
      selection = Random.Range (0,2);
      textQuestion.text     =  questions[selection].question  ;     //need a method          
 
  }
  public void CheckAnswer(){
    if(answer.text == questions[selection].correctAnswer){
      //do something, answer correct
    }else{
      //do something, answer incorrect
    }
  }*/
}
