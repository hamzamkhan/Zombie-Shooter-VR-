using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playButton : MonoBehaviour
{
     public void changemenuscene(string scenename) 
     { 
         Application.LoadLevel(scenename); 
     }
    public void Click()
    {
        Application.LoadLevel("level1");
    }
}
