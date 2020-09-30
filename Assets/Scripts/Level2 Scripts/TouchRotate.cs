using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotate : MonoBehaviour
{
    // Start is called before the first frame update
     private void OnMouseDown() {
        if(!Level2Controller.youwin)
        {
            transform.Rotate(0f,0f,90f);
        }
    }
}
