using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigoRapido : MonoBehaviour
{
    public int vida = 100;
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
            if (vida < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}