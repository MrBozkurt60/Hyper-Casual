using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawnController : MonoBehaviour
{
    public GameObject LastGround, GroundPrefab;
    GameObject newGroundObject;
    int GroundDirection;

    void Start()
    {
        GenerateNewRandomGround();
    }

    public void GenerateNewRandomGround()
    {
        for(int i = 0; i < 1000; i++)
        {
            CreateNewGround();
        }
    }

    void CreateNewGround()
    {
        GroundDirection = Random.Range(0, 2);

        if(GroundDirection == 0)
        {
            newGroundObject = Instantiate(GroundPrefab, new Vector3(LastGround.transform.position.x - 1f , LastGround.transform.position.y , LastGround.transform.position.z), Quaternion.identity);
            LastGround = newGroundObject;

        }
        else
        {
            newGroundObject = Instantiate(GroundPrefab, new Vector3(LastGround.transform.position.x, LastGround.transform.position.y, LastGround.transform.position.z + 1f), Quaternion.identity);
            LastGround = newGroundObject;
        }
    }
}
