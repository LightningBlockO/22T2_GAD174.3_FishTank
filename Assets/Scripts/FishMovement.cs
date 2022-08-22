using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float speed = 2f;
    public ParticleSystem ParticleSystem;
    void Start()
    {
        ParticleSystem.Stop();
    }

   
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            ParticleSystem.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
            ParticleSystem.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            ParticleSystem.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            ParticleSystem.Play();
        }
        
    }
}
