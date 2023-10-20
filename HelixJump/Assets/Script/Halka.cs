using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halka : MonoBehaviour
{
    [SerializeField] Transform top;
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();

    }

}
