using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounds : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
