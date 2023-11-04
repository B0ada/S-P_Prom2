using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigoRapido : MonoBehaviour
{
    public int vida = 100;
    public GameObject objetoSuelto; // Referencia al objeto que el enemigo sueltará

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bala"))
        {
            vida -= 40;
            Destroy(collision.gameObject);
            if (vida <= 0)
            {
                // Instanciar el objeto suelto en la posición del enemigo y luego destruir el enemigo
                Instantiate(objetoSuelto, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
