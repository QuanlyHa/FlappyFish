using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameStart;

    public GameObject ShopPage;
    public GameObject ShopButton;

    AudioManage audioManage;

    private bool gamestarted = false;
    private bool seacondTime = false;


    void Awake()
    {
        audioManage = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManage>();
    }
    void Start()
    {

        Time.timeScale = 0f;
        gameOverPanel.SetActive(false);
        ShopButton.SetActive(true);
     
    }

    void Update()
    {
        //Oyun baþlayýnca oyunu durdur 
        if (Input.GetMouseButton(0) & !gamestarted & !ShopPage.activeSelf)
        {
            if (!EventSystem.current.IsPointerOverGameObject())
            {
                StartGame();
            }
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
        ShopButton.SetActive(false);
        gamestarted = true;
    }


    public void OpenShop()
    {

        ShopPage.SetActive(true);
        if(ShopPage.activeSelf & seacondTime)
        {
            CloseShop();
        }
        else
        {
            seacondTime = true;
        }
    }

    public void CloseShop()
    {
        ShopPage.SetActive(false);
        seacondTime = false;
    }
}
