using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundFallController : MonoBehaviour
{
    [SerializeField] Rigidbody rigidBody;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    public IEnumerator SetRigidbodyValue()
    {
        yield return new WaitForSeconds(0.5f);

        rigidBody.useGravity = true;
        rigidBody.isKinematic = false;
    }
}
