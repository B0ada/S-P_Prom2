using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Mirar : MonoBehaviour
{
    private Vector3 Objetivo;
    [SerializeField] private Camera camara;

    [SerializeField] private float VelocidadMovimiento;
    private Vector2 Direccion;
    private Rigidbody2D rb2D;
    private Vector2 input;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Objetivo = camara.ScreenToWorldPoint(Input.mousePosition);

        float AnguloRadianes = Mathf.Atan2(Objetivo.y - transform.position.y, Objetivo.x - transform.position.x);
        float AngulosGrados = (180 / Mathf.PI) * AnguloRadianes - 0;
        transform.rotation = Quaternion.Euler(0, 0, AngulosGrados);
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        Direccion = input.normalized;
    }
    private void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + Direccion * VelocidadMovimiento * Time.fixedDeltaTime);
    }
}
