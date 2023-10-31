using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public static int contador = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("Cubo"))
        {
            contador++;
            Debug.Log("Canasta anotada. Contador: " + contador);
            Destroy(collision.gameObject);
            GenerarNuevoCubo();
        }

    }

    private void GenerarNuevoCubo()
    {
        Debug.Log("Funciona.");
        GameObject nuevoCubo = Instantiate(cuboPrefab);
    }
}
