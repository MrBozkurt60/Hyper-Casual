using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform BallTransform;
    Vector3 offset, newPosition ;
    [SerializeField] [Range(0 , 3)] float LerpValue;   //range ayarlama ile ilgili unity arayüzünde 
    
    void Start()
    {
        offset = transform.position - BallTransform.position;
    }

    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, BallTransform.position + offset, LerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
