using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{
   
    private void Update()
    {
        if (Input.touchCount == 0)
        {
            return;
        }

        var touch = Input.GetTouch(0);

        //swipe
       if (touch.deltaPosition.x > 10)
       {
        Debug.Log("Right");
       }
       else if(touch.deltaPosition.x <= 10)
       Debug.Log("left");

        //tap
        if(touch.tapCount > 0)
        {
            Debug.Log(touch.tapCount);
        }


    }

    private void OnDrawGizmos()
    {
        foreach (var touch in Input.touches)
        {
            var touchWorldPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchWorldPos.z = 0;
            switch (touch.phase)
        {
            case TouchPhase.Began:
                Gizmos.color = Color.green;
                break;
            case TouchPhase.Stationary:
                Gizmos.color = Color.blue;
                break;
            case TouchPhase.Moved:
                Gizmos.color = Color.red;
                break;
            case TouchPhase.Ended:
                Gizmos.color = Color.yellow;
                break;
            case TouchPhase.Canceled:
                Gizmos.color = Color.black;
                break;
            default:
                break;
        }
            Gizmos.DrawSphere(touchWorldPos,0.5f);
        }
    }
}
