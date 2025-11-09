using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;
    public float spawnDelay = 2f;
    public float minY = -1f;
    public float maxY = 1.5f;
    public float chance = 100f; 
    public float canMove;

    private float timer = 0f;

    public GameObject Pipe;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

        timer += Time.deltaTime;
        if (timer >= spawnDelay)
        {
            SpawnPipe();
            print("Pipe Spawned");
            timer = 0f;
        }
    }

    void SpawnPipe()
    {

        float randomY = Random.Range(minY, maxY);
        Vector3 spawnPosition = new Vector3(10f, randomY, 0f);
        GameObject newPipe = Instantiate(Pipe, spawnPosition, Quaternion.identity);
        float UpSpeed = Random.Range(2f, 6f);
        newPipe.GetComponent<PipeMove>().UpSpeed = UpSpeed;

    }
}
