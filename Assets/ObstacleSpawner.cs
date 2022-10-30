using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject Obstacle;
    GameObject obs;
    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;
    
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    

    void Spawn()
    {
        float X=Random.Range(minX,maxX);
        float Y=Random.Range(minY,maxY);

         obs= Instantiate(Obstacle,transform.position + new Vector3(X,Y,0),transform.rotation);
    }
    void Update()
    {
        obs.transform.position=obs.transform.position-new Vector3(1.5f*Time.deltaTime,0,0);
        if(Time.time>SpawnTime)
        {
            Destroy(obs,10);
        }
    }
}
