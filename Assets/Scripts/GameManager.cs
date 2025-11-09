using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameStart;

    AudioManage audioManage;

    private bool gamestarted = false;


    void Awake()
    {
        audioManage = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManage>();
    }
    void Start()
    {

        Time.timeScale = 0f;
        gameOverPanel.SetActive(false);
     
    }

    void Update()
    {
        if (Input.GetMouseButton(0) & !gamestarted)
        {
            StartGame();
        }
    }

    public void GameOver()
    {
        
        //Time.timeScale = 0f;
        gameOverPanel.SetActive(true);

    }


    public void RestartGame()
    {
     
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        gameStart.SetActive(false);
        gamestarted = true;
    }
}
