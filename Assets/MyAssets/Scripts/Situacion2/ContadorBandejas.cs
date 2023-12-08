using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContadorBandejas : MonoBehaviour
{
    int contador = 0;
    public GameObject cambiarEscena;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bandeja")
        {
            Debug.Log(contador);
            contador++;
            if (contador == 2)
            {
                cambiarEscena.GetComponent<CambiarEscena>().saltarEscena();
            }
        }
    }
}
