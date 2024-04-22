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

    private void Update()
    {
        transform.Translate(Vector2.left*velocidad*Time.deltaTime);
        
    }

  
}
