using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scane_manager : MonoBehaviour
{
   
   public void quit()
    {
         Application.Quit();
    }
public void goHome()
    {
        SceneManager.LoadScene(0);
    }
     public void replay()
    {
        SceneManager.LoadScene("GamePlay");
    }
     public void load_Level3()
    {
        SceneManager.LoadScene("Level3");
    }
     public void load_Level2()
    {
        SceneManager.LoadScene("Level2");
    }
     public void load_Level1()
    {
        SceneManager.LoadScene("GamePlay");
    }
     public void load_LevelList()
    {
        SceneManager.LoadScene("LevelList");
    }
}
