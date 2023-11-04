using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Healh2 : MonoBehaviour
{
    public int saludMaxima = 100;
    public int saludActual;
    public Image barraDeSalud;
    public float tiempoParaRecuperar = 5f;
    public int cantidadDeRecuperacion = 10;
    public int dinero = 0;
    public TMP_Text textoDeDinero;

    Vector3 escalaOriginal;

    void Start()
    {
        saludActual = saludMaxima;
        escalaOriginal = barraDeSalud.rectTransform.localScale;
        ActualizarTextoDeDinero();
        StartCoroutine(RecuperarSaludConElTiempo());
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("tanke"))
        {
            RecibirDanio(30); // Aplica 10 de daño al jugador al colisionar con un objeto que tiene el tag "Enemigo".
        }
        else if (collision.CompareTag("comun"))
        {
            RecibirDanio(20);
        }
        else if (collision.CompareTag("rapido"))
        {
            RecibirDanio(30);
        }
        else if (collision.CompareTag("Dinero"))
        {
            dinero += 50; // El jugador recibe 50 unidades de dinero al colisionar con un objeto que tiene el tag "Dinero".
            ActualizarTextoDeDinero();
            Destroy(collision.gameObject); // Destruye el objeto de dinero.
        }
    }

    void RecibirDanio(int cantidadDanio)
    {
        saludActual -= cantidadDanio;
        saludActual = Mathf.Clamp(saludActual, 0, saludMaxima);
        StartCoroutine(FeedbackDeSalud());

        float escalaX = (float)saludActual / saludMaxima;
        Vector3 nuevaEscala = escalaOriginal;
        nuevaEscala.x = escalaX;
        barraDeSalud.rectTransform.localScale = nuevaEscala;

        if (saludActual == saludMaxima)
        {
            barraDeSalud.rectTransform.localScale = escalaOriginal;
        }
    }

    void ActualizarTextoDeDinero()
    {
        textoDeDinero.text = "Dinero: " + dinero.ToString();
    }

    IEnumerator FeedbackDeSalud()
    {
        float saludInicial = barraDeSalud.fillAmount;

        float t = 0;
        while (t < 1)
        {
            t += Time.deltaTime / 0.2f; 
            barraDeSalud.fillAmount = Mathf.Lerp(saludInicial, (float)saludActual / saludMaxima, t);
            yield return null;
        }
    }

    IEnumerator RecuperarSaludConElTiempo()
    {
        while (true)
        {
            yield return new WaitForSeconds(tiempoParaRecuperar);

            if (saludActual < saludMaxima)
            {
                saludActual += cantidadDeRecuperacion;
                saludActual = Mathf.Clamp(saludActual, 0, saludMaxima);
                ActualizarBarraDeSalud();
            }
        }
    }

    void ActualizarBarraDeSalud()
    {
        float escalaX = (float)saludActual / saludMaxima;
        Vector3 nuevaEscala = escalaOriginal;
        nuevaEscala.x = escalaX;
        barraDeSalud.rectTransform.localScale = nuevaEscala;
    }

}
