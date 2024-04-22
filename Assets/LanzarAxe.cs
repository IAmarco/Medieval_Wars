using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LanzarAxe : MonoBehaviour
{
    [SerializeField] private Transform controladorDisparo;
    [SerializeField] private GameObject Acha;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F4))
        {
            Disparar();
        }
    }

    private void Disparar()
    {

        Instantiate(Acha, controladorDisparo.position, controladorDisparo.rotation);
    }
}
