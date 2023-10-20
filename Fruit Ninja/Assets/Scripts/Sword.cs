using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    [SerializeField] GameObject CutPrefab;
    [SerializeField] float CutLifeTime;
    bool dragging;
    Vector2 SwipeStart;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            dragging = true;
            SwipeStart = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        else if(Input.GetMouseButtonUp(0) && dragging)
        {
            dragging = false;
            CutSpawner();
        }
    }

    void CutSpawner()
    {
        Vector2 SwipeEnd = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GameObject CutInstance = Instantiate(CutPrefab, SwipeStart, Quaternion.identity);

        CutInstance.GetComponent<LineRenderer>().SetPosition(0, SwipeStart);
        CutInstance.GetComponent<LineRenderer>().SetPosition(1, SwipeEnd);

        Vector2[] ColliderPoints = new Vector2[2];
        ColliderPoints[0] = Vector2.zero;
        ColliderPoints[1] = SwipeEnd - SwipeStart;

        CutInstance.GetComponent<EdgeCollider2D>().points = ColliderPoints;

        Destroy(CutInstance, CutLifeTime);
    }
}
