using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody rb;

    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;

        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * speed * 6;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            
            transform.position += Vector3.right * speed * 4;
            rb.useGravity = false;

        //  rb.velocity = Vector2.right * speed * 6;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            rb.useGravity = true;
        }

    }

    void OnCollisionEnter(Collision collision)
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
        Sound.Instance.GetComponent<AudioSource>().Pause();
    }
}
