using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float HorizontalSpeed , horizontalLimit , moveSpeed;
    private float horizontal;
    [SerializeField] private List<GameObject> balls = new List<GameObject>();
    void Start()
    {
        
    }

    void Update()
    {
        HorizontalBallMove();
        VerticalBallMove();
    }

    void HorizontalBallMove()
    {
        float newX;

        if(Input.GetMouseButton(0))
        {
            horizontal = Input.GetAxisRaw("Mouse X");   //mouse yatay
        }
        else
        {
            horizontal = 0;
        }

        newX = transform.position.x + horizontal * HorizontalSpeed * Time.deltaTime;
        newX = Mathf.Clamp(newX, -horizontalLimit, horizontalLimit);

        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    void VerticalBallMove()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)   //toplama mekaniði
    {
        if(other.gameObject.CompareTag("stack"))
        {
            other.gameObject.transform.SetParent(transform);  //ana topun arkasýna getir
            other.gameObject.GetComponent<SphereCollider>().enabled = false;
            other.gameObject.transform.localPosition = new Vector3(0, 0, balls[balls.Count - 1].transform.position.z - 1f);
            balls.Add(other.gameObject);
        }
    }
}
