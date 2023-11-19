using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public static int contadorRojo = 0;
    public int numBolas = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Cubo"))
        {
            contadorRojo++;
            Debug.Log("Canasta anotada. Contador: " + contadorRojo);
            Destroy(collision.gameObject);
            GenerarNuevoCubo();
        }
        else if (collision.gameObject.layer == LayerMask.NameToLayer("Bola"))
        {
            numBolas++;
            Debug.Log("Bola: " + numBolas);
            Destroy(collision.gameObject);
        }

    }

    private void GenerarNuevoCubo()
    {
        Debug.Log("Funciona.");
        GameObject nuevoCubo = Instantiate(cuboPrefab);
    }
}
