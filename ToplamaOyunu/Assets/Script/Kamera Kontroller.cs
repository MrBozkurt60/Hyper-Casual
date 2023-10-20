using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontroller : MonoBehaviour
{
    [SerializeField] Transform ballTransform;
    Vector3 offset;  //mesafe
    [SerializeField] float lerpTime;
    void Start()
    {
        offset = transform.position - ballTransform.position;
    }

    void LateUpdate()
    {
        Vector3 mewPosition = Vector3.Lerp(transform.position, ballTransform.position + offset, lerpTime * Time.deltaTime);
        transform.position = mewPosition;
    }
}
