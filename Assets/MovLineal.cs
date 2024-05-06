using System;
using System.Collections;
using System.Collections.Generic;
using Playable;
using Unity.VisualScripting;
using UnityEngine;

public class MovLineal : MonoBehaviour
{
    [SerializeField] private float velocidad = 10f;
    [SerializeField] private float RecibirDano;
    [SerializeField] private float distanciaMax = 100f;
    [SerializeField] private float distanciaRecorrida = 100f;
    private Rigidbody2D Rb;


    private void Update()
    {
        transform.Translate(Vector2.left * 10 * Time.deltaTime);

        distanciaRecorrida += velocidad * Time.deltaTime;

        if (distanciaRecorrida >= distanciaMax)
        { velocidad = 0f; }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Witch"))
        {
            Player saludWitch = other.GetComponent<Player>();
        
        if (saludWitch != null) 
            {
                float RecibirDano= saludWitch.RecibirDano;
            
        }

        Destroy (gameObject);
           
        }
    }
}
    
