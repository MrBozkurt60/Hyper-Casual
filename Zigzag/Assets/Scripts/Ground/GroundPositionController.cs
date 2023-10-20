using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPositionController : MonoBehaviour
{
    GroundSpawnController groundSpawnController;
    Rigidbody rb;
    [SerializeField] float EndYValue;
    int groundDirection;

    void Start()
    {
        groundSpawnController = FindObjectOfType<GroundSpawnController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        CheckGroundVerticalPosition();
    }

    void CheckGroundVerticalPosition()
    {
        if(transform.position.y <= EndYValue)
        {
            SetRigidbodyValues();
            groundDirection = Random.Range(0, 2);
        }

        if (groundDirection == 0)
        {
            transform.position =new Vector3(groundSpawnController.LastGround.transform.position.x - 1f, groundSpawnController.LastGround.transform.position.y, groundSpawnController.LastGround.transform.position.z);

        }
        else
        {
            transform.position =new Vector3(groundSpawnController.LastGround.transform.position.x, groundSpawnController.LastGround.transform.position.y, groundSpawnController.LastGround.transform.position.z + 1f);
        }

        groundSpawnController.LastGround = gameObject;
    }

    void SetRigidbodyValues()
    {
        rb.useGravity = false;
        rb.isKinematic = true;
    }
}
