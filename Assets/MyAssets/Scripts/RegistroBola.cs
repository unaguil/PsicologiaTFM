using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegistroBola : MonoBehaviour
{

    public static int contador = 0;
    public string layer;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer(layer))
        {
            contador++;
            Debug.Log("Color: "+layer+" Canasta anotada. Contador: " + contador);
            Destroy(collision.gameObject);
        }

    }

}
