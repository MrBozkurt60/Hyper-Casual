using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    int skor;
    [SerializeField] TextMeshProUGUI SkorYazisi;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OyunSkoru(int HalkaSkor)
    {
        skor += HalkaSkor;
        SkorYazisi.text = skor.ToString();
    }
}
