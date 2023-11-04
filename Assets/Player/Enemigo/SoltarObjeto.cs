using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltarObjeto : MonoBehaviour
{
    public GameObject objetoASoltar; 

    private void Start()
    {
       
    }

    private void Update()
    {
        
    }

    public void Morir()
    {
       
        Instantiate(objetoASoltar, transform.position, Quaternion.identity);
    }
}
