using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorDeCubos : MonoBehaviour
{
    public GameObject cuboPrefab;
    public static int contadorRojo = 0;
    public static int numBolas = 0;
    public GameObject scriptGameObject;

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
            if (numBolas == 2)
            {
                if (scriptGameObject != null)
                {
                    var scriptComponent = scriptGameObject.GetComponent<BolaTrucada>();
                    if (scriptComponent == null)
                    {
                        scriptComponent = collision.gameObject.AddComponent<BolaTrucada>();
                        Debug.Log("Se ha adjuntado el script " + scriptGameObject.GetType() + " al objeto " + collision.gameObject.name);
                    }
                    else
                    {
                        Debug.Log("El objeto " + collision.gameObject.name + " ya tiene el script adjunto");
                    }
                }
               
            }
        }

    }

    private void GenerarNuevoCubo()
    {
        Debug.Log("Funciona.");
        GameObject nuevoCubo = Instantiate(cuboPrefab);
    }
}
