using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBolas2 : MonoBehaviour
{
    public GameObject muro;
    int contador = 0;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(contador);
        contador++;
        if (contador == 2) 
        {
            StartCoroutine(muro.GetComponent<BajarMuro>().Animacion());
        }
        
    }
}
