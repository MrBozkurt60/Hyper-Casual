using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cut : MonoBehaviour
{
    private Manager manager;

    private void Start()
    {
        manager = GameObject.FindObjectOfType<Manager>();
    }


    private void OnTriggerEnter2D(Collider2D temas)
    {
        if(temas.gameObject.tag == "fruit")
        {
            Destroy(temas.gameObject);
            manager.score += 1;

        }
        else if(temas.gameObject.tag == "bomba")
        {
            manager.RestartGame();
        }
    }
}
