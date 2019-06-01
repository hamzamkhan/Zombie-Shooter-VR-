using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttontouch : MonoBehaviour {

    void touch()
    {
        if (Input.touchCount >= 1)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Debug.Log("Touch Pressed");
            }

            if (Input.touches[0].phase == TouchPhase.Ended)
            {
                Debug.Log("Touch Lifted/Released");
            }
        }


    }

}
