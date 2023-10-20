using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDataTransmiter : MonoBehaviour
{
    [SerializeField] GroundFallController groundFallController;

    public void SetGroundRigidbodyvalues()
    {
        StartCoroutine(groundFallController.SetRigidbodyValue());
    }
}
