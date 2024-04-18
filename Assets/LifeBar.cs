using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LifeBar : MonoBehaviour
{

    private Slider slider;


    void Start()
    {
        slider = GetComponent<Slider>();
    }

    public void CambiarVidaMaxima(float vidaMaxima)

    {
      slider.maxValue= vidaMaxima;
    }

    public void CambiarvidaActual(float cantidadVida)
    {
        slider.value= cantidadVida;

    }


    public void InicializarBarradeVida(float cantidadVida)
    {
        CambiarVidaMaxima(cantidadVida);
        CambiarVidaMaxima(cantidadVida);
    }
    
}
