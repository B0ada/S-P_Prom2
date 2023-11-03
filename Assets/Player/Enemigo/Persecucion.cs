using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persecucion : MonoBehaviour
{
    public Transform jugador;
    public float velocidadMovimiento = 2.0f;
    public float distanciaPersecucion = 5.0f;

    private Rigidbody2D rb2d;

    void Start()
    {
        // Encuentra el jugador usando FindWithTag en el Start para evitar problemas si el jugador se desactiva o se destruye después.
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (jugador != null)
        {
            Detecion();
        }
    }

    private void Detecion()
    {
        float distanciaAlJugador = Vector2.Distance(transform.position, jugador.position);

        if (distanciaAlJugador <= distanciaPersecucion)
        {
            Vector2 direccionAlJugador = (jugador.position - transform.position).normalized;

            rb2d.velocity = direccionAlJugador * velocidadMovimiento;
        }
        else
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}
