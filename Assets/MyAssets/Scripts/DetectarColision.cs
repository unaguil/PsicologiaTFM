using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectarColision : MonoBehaviour
{
    private Vector3 posicion = new Vector3(1f, 0f, -3f);
    private int contador = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Agujeros"))
        {
            Debug.Log("La pelota ha atravesado la pared");
            contador++;

            if (contador == 2)
            {
                Debug.Log("se cae la pared");
            }
        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Desaparece"))
        {
            Debug.Log("Llega");
            gameObject.transform.position = posicion;
        }
    }
}
