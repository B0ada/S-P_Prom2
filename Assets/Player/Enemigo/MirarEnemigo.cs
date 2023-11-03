using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirarEnemigo : MonoBehaviour
{
    public Transform jugador;
    public float anguloInicial = 0;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, anguloInicial));
    }

    void Update()
    {
        if (jugador != null)
        {
            Vector3 direccionAlJugador = jugador.position - transform.position;

            float angulo = Mathf.Atan2(direccionAlJugador.y, direccionAlJugador.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angulo + anguloInicial));
        }
    }
}
