using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int vidaMaxima = 100;
    public int vidaActual;

    public BarraVida barraVida; 

    void Start()
    {
        vidaActual = vidaMaxima;
        barraVida.SetVidaMaxima(vidaMaxima);
    }


    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tanke"))
        {
            TakeDamage(30);
            if (vidaActual <= 0)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.CompareTag("comun"))
        {
            TakeDamage(20);
            if (vidaActual <= 0)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.CompareTag("rapido"))
        {
            TakeDamage(30);
            if (vidaActual <= 0)
            {
                Destroy(gameObject);
            }
        }
        void TakeDamage(int damage)
        {
            vidaActual -= damage;

            barraVida.SetVida(vidaActual);
        }
    }
}
