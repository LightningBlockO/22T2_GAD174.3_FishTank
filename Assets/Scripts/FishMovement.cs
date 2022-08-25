using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishMovement : MonoBehaviour
{
    [Header("Movement")]
    public CharacterController controller;
    public float speed = 2f;

    [Header("Effects")]
    public ParticleSystem bubbleTrailEffect;
    public GameObject playerMovingSound; 
    private ParticleSystem.EmissionModule bubbleTrailEmission;
    [Header("Audio sources")]
    public AudioSource movingPlants;
    public AudioSource startSplash;
    public AudioSource collisionSound;
    
    void Start()
    {
        bubbleTrailEmission = bubbleTrailEffect.emission;
        bubbleTrailEmission.rateOverTime = 0f;
        playerMovingSound.SetActive(false);
        startSplash.Play();
    }


   
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * x * 0.5f);
        

        if (x != 0 || z != 0)
        {
            bubbleTrailEmission.rateOverTime = 10f;
            playerMovingSound.SetActive(true);
            
        }
        else
        {
            bubbleTrailEmission.rateOverTime = 0f;
            playerMovingSound.SetActive(false);
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        movingPlants.Play();
    }

    private void OnCollisionEnter(Collision other) 
    {
        collisionSound.Play();
    }
}
