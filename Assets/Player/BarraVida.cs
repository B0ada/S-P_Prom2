using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraVida : MonoBehaviour
{
    public Slider slider;

    public Image barraVida;


    public void SetVidaMaxima(int vida)
    {
        slider.maxValue = vida;
        slider.value = vida;
    }
    public void SetVida(int vida)
    {
        slider.value = vida;
    }

}
