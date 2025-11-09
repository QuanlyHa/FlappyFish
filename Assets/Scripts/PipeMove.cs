using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float speed;
    public float UpSpeed;
    public float chance;

    public float canMove;

    void Start()
    {
        canMove = Random.Range(0f, 100f);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (canMove < chance)
        {
            print("Pipe Moving");
            gameObject.transform.Translate(Vector3.up * Mathf.Sin(Time.time) * UpSpeed * 0.3f * Time.deltaTime);
        }
        if (gameObject.transform.position.x < -20)
        {
            Destroy(gameObject);
            print("Pipe Destroyed");
        }

    }
}
