using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public static int contadorRojo = 0;
    public int numBolas = 0;
    public GameObject canvas;
    public GameObject tapa;
    public int temporizador = 60;

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
            if (numBolas >= 4)
            {
                Debug.Log("Se va a activar el temporizador");
                tapa.SetActive(true);
                StartCoroutine(ActivarInterfazRetardado()); //Por qué hay que hacer aquí startCoroutine y otras veces no?
            }
        }

    }

    private void GenerarNuevoCubo()
    {
        Debug.Log("Funciona.");
        GameObject nuevoCubo = Instantiate(cuboPrefab);
    }


    IEnumerator ActivarInterfazRetardado()
    {
        Debug.Log("Temporizador activado");
        yield return new WaitForSeconds(temporizador);
        canvas.SetActive(true);

    }
}
