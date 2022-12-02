using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalls : MonoBehaviour
{
    public GameObject wall;
    public float height;
    public float speed;
    public float maxTime;

    private float timer = 0f;

    void Start()
    {
        GameObject newWall = Instantiate(wall);
        newWall.transform.position = transform.position + new Vector3 (0, Random.Range(-height, height), 0);
    }


    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newWall = Instantiate(wall);
            newWall.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newWall, 20f);
            timer = 0f;
        }

        timer += Time.deltaTime;
    }
}
