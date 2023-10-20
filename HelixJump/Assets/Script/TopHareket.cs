using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareket : MonoBehaviour
{
    [SerializeField] Rigidbody Rigidbody;
    [SerializeField] float ZiplamaGucu;
    [SerializeField] GameObject SplashPrefab;
    GameManager gameManager;
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if(Time.timeScale == 0 && Input.GetKeyDown(KeyCode.R))
        {
            gameManager.Restart();
            Time.timeScale = 1;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody.AddForce(Vector3.up * ZiplamaGucu);   //basamakla temas oldu�unda yukar� bir kuvvet uygulas�n

        GameObject splash = Instantiate(SplashPrefab, transform.position + new Vector3(0f , -0.2f, 0f), transform.rotation);   //topun temas etti�i yerde k�rm�z� iz
        splash.transform.SetParent(collision.gameObject.transform);

        string MaterialName = collision.gameObject.GetComponent<MeshRenderer>().material.name;   //temas etti�i objenin material ad�na g�re i�lemler yap�lacak

       if(MaterialName == "tehlikeli (Instance)")   //oyun yeniden baslayacak
       {
            gameManager.Restart();
       }
       else if(MaterialName == "zemin (Instance)") //oyun tamamlanacak (zemin)
       {
            Time.timeScale = 0;
       }
    }

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "bosluk")
        {
            gameManager.OyunSkoru(25);
        }
    }
}
