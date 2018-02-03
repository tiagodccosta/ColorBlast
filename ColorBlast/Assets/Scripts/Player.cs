using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D playerRB;
    


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            moveLeft();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            moveRigth();
        }

        TouchMove();
    }


    public void moveLeft()
    { 
        iTween.RotateBy(gameObject, iTween.Hash("z", 0.25, "time", .15, "delay", 0));
    }

    public void moveRigth()
    {
        iTween.RotateBy(gameObject, iTween.Hash("z", -0.25, "time", .15, "delay", 0));
    }



    
    void TouchMove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            float middle = Screen.width / 2;
            float middle2 = Screen.height / 2;

            if (touch.position.x < middle && touch.phase == TouchPhase.Began)
            {
                moveLeft();
            }

            else if (touch.position.x > middle && touch.phase == TouchPhase.Began)
            {
                moveRigth();
            }
        }
    }
}
