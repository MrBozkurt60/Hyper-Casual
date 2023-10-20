using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCollisionController : MonoBehaviour
{
    [SerializeField] GroundDataTransmiter groundDataTransmiter;
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ball"))
        {
            groundDataTransmiter.SetGroundRigidbodyvalues();
        }
    }
}
