using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerSc : MonoBehaviour
{
    AudioManage audioManage;


    public float flapSpeed = 5f;
    private Rigidbody2D rb;
    bool isDead = false;

    public GameManager gameManager;

    void Awake()
    {
        audioManage = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManage>();
    }

    void Start()
    {
      rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {

                rb.velocity = Vector2.up * flapSpeed;
                audioManage.PlaySFX(audioManage.jumpSFX);
            
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 2f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Death Condition
        if (collision.gameObject.CompareTag("Walls") & !isDead)
        {
            isDead = true;
            audioManage.PlaySFX(audioManage.deathSFX);
            gameManager.GameOver();   
        }

        //Score Condition
        if (collision.gameObject.CompareTag("ScoreZone") & !isDead)
        {
            print("Score Up");
            audioManage.PlaySFX(audioManage.scoreSFX);
            ScoreManager.Instance.ScoreUp();
        }


    }

}
