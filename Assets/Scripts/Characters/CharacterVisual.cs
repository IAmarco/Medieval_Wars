using UnityEngine;
using UnityEngine.UI;
namespace Characters
{
    public class CharacterVisual : MonoBehaviour
    {
        public Transform attackPositon;
        public Transform defense ;
        private Slider slider;

        private void Start()
        {
            slider = GetComponent<Slider>();
        }

        public void CambiarVidaMaxima(float vidaMaxima)
        {
            slider.maxValue = vidaMaxima;

        }

        public void CambiarVidaActual(float cantidadVida)
        {
            slider.value = cantidadVida;
        }

        public void InicializarHealth(float cantidadVida)
        {
            CambiarVidaMaxima(cantidadVida);
            CambiarVidaActual(cantidadVida);
        }
    }
}