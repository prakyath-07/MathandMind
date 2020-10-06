using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class populatescript : MonoBehaviour
{
    
    public GameObject Prefab;
    //public int noofoptions;

    private List<int> _validNumbers;

    public int number;

    private void Awake()
    {
        _validNumbers = new List<int>();
        for (int i = 0; i <= 100; i++)
            _validNumbers.Add(i);
    }
    
    //to add prefabs to grid layout
public void populate()
{
      int orginalres = GameObject.Find("GameController").GetComponent<GameManager>().numberGenerator();
      print("its orginal result from populate fucntion "+orginalres);
    GameObject newObj;
     foreach (Transform child in transform)
     {
     GameObject.Destroy(child.gameObject);
     }
  
    int noofoptions= Random.Range(4,10);
     int randpos = Random.Range(0,noofoptions-1);
    for(int i=0;i<noofoptions;i++)
    {
         int x = GetRandomNumber();
        if(i==randpos)
         {
             newObj = (GameObject)Instantiate(Prefab,transform);
            newObj.GetComponentInChildren<Text>().text=orginalres.ToString("");
         }
         else{
        newObj = (GameObject)Instantiate(Prefab,transform);
        newObj.GetComponentInChildren<Text>().text=x.ToString("");
         }
       
    }
}
//generate randmo
private int GetRandomNumber()
    {
        var nextIndex = Random.Range(0, _validNumbers.Count - 1);
        var result    = _validNumbers[nextIndex];
        _validNumbers.RemoveAt(nextIndex);
        return result;
    }
}
