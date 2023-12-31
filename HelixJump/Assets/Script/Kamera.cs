using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    [SerializeField] Transform top;
    Vector3 mesafe;   //top ile kamera arasındaki mesafe 
    [SerializeField] float hiz;

    void Start()
    {
        mesafe = transform.position - top.position;   //top ile kamera arasındaki mesafe tanımlanır
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 konum = Vector3.Lerp(transform.position, mesafe + top.position, hiz);
        transform.position = konum;
    }
}
