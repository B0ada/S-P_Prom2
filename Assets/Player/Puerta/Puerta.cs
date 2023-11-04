using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Puerta : MonoBehaviour
{
    public UnityEvent onPlayerCollision;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Invoca el Unity Event para mostrar el mensaje de Game Over.
            onPlayerCollision.Invoke();
        }
    }
}
