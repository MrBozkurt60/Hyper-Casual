using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] float minX, maxX, StartTime;
    float time;
    [SerializeField] Sprite[] sprites;
    void Start()
    {
        
    }

    void Update()
    {
        if(time <= 0)
        {
            SpawnObject();
            time = StartTime;

        }
        else
        {
            time -= Time.deltaTime;
        }
    }

    void SpawnObject()
    {
        GameObject NewPrefab = Instantiate(prefab);

        NewPrefab.transform.position = new Vector2(Random.Range(minX, maxX), transform.position.y);

        Sprite RandomSprite = sprites[Random.Range(0, sprites.Length)];
        NewPrefab.GetComponent<SpriteRenderer>().sprite = RandomSprite;
    }
}
