using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balla : MonoBehaviour
{
    [SerializeField] private float velocidad;
    [SerializeField] private float tiempoDeVida = 2f;

    private float tiempoInicial;

    void Start()
    {
        tiempoInicial = Time.time;
    }

    void Update()
    {
        transform.Translate(Vector2.up * velocidad * Time.deltaTime);


        if (Time.time - tiempoInicial >= tiempoDeVida)
        {
            Destroy(gameObject);
        }
    }
}
