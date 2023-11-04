using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaEnemigoTanke : MonoBehaviour
{
    public int vida = 100;
    public GameObject objetoSuelto;
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
            vida -= 10;
            Destroy(collision.gameObject);
            if (vida < 0)
            {
                Instantiate(objetoSuelto, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
