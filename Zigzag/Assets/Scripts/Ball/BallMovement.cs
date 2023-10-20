using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    [SerializeField] BallDataTransmiter ballDataTransmiter;
    [SerializeField] float BallMoveSpeed;

    private void Update()
    {
        SetBallMovement();

        if(transform.position.y < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SetBallMovement()
    {
        transform.position += ballDataTransmiter.GetBallDirection() * BallMoveSpeed * Time.deltaTime;
    }
}
