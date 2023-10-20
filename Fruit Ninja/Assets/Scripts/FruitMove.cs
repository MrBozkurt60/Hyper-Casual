using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitMove : MonoBehaviour
{
    [SerializeField] Rigidbody2D Rigidbody;
    [SerializeField] float minX, maxX, minY, maxY;
    [SerializeField] float LifeTime;

    void Start()
    {
        Rigidbody.velocity = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));   //meyvenin çýkacaðý yer
        Destroy(gameObject, LifeTime);   //kesilmezse yok olsun
    } 

}
