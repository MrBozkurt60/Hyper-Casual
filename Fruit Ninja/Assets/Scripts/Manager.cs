using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public int score;
    [SerializeField] TextMeshProUGUI SkorYazisi;
    void Start()
    {
        
    }

    void GameScore()
    {
        SkorYazisi.text = score.ToString();
    }

    void Update()
    {
        GameScore();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
