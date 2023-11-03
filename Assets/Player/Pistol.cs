using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField] private Transform ControladorDisparo;
    [SerializeField] private GameObject Bala;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Disparo();
        }
    }
    private void Disparo()
    {
        Instantiate(Bala, ControladorDisparo.position, ControladorDisparo.rotation);
    }
}
