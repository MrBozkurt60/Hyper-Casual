using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInputController : MonoBehaviour
{
    private Vector3 BallDirection;  
    void Start()
    {
        BallDirection = Vector3.left;
    }

    void Update()
    {
        HandleBallInputs();
    }

    void HandleBallInputs()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetTouch(0).tapCount ==0)
        {
            ChangeBallDirection();
        }
    }

    void ChangeBallDirection()
    {
        if(BallDirection.x == -1)
        {
            BallDirection = Vector3.forward;
        }
        else
        {
            BallDirection = Vector3.left;
        }
    }

    public Vector3 BallDirectionFor()
    {
        return BallDirection;
    }
}
