using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCombat : MonoBehaviour
{




    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private HealthBar health;
    // Start is called before the first frame update
    private void Start()
    {
        vida = maximoVida;
        health.InicializarHealth(vida);
    }

}


