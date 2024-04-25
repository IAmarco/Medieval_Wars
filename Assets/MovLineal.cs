using System;
using System.Collections;
using System.Collections.Generic;
using Playable;
using Unity.VisualScripting;
using UnityEngine;

public class MovLineal : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float Dano;
    private Rigidbody2D Rb;
    private void Update()
    { //
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Jugador"))
        {
            other.GetComponent<Player>().TomarDano(Dano);
            Destroy(gameObject);
        }
    }
}
