using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int Vidaplayer = 100;
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
        if (collision.CompareTag("tanke"))
        {
            Vidaplayer -= 30;
            if (Vidaplayer < 0)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.CompareTag("comun"))
        {
            Vidaplayer -= 20;
            if (Vidaplayer < 0)
            {
                Destroy(gameObject);
            }
        }
        else if (collision.CompareTag("rapido"))
        {
            Vidaplayer -= 30;
            if (Vidaplayer < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
