using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle1;
    public GameObject obstacle2;
    public GameObject obstacle3;
    public GameObject obstacle4;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    private int check_car;

    

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
        
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        this.check_car= (int)Random.Range(0,4);
        if(this.check_car == 0)
        {
            Instantiate(obstacle1, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else
        if(this.check_car == 1)
        {
            Instantiate(obstacle2, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else
        if(this.check_car == 2)
        {
            Instantiate(obstacle3, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else
        if(this.check_car == 3)
        {
            Instantiate(obstacle4, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else
        {
            Instantiate(obstacle1, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

        }
    }
}
