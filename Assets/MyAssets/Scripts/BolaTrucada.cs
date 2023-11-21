using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaTrucada : MonoBehaviour
{
    public float fuerzaMin;
    public float fuerzaMax;
    public Vector3 fuerza;

    public void Prueba()
    {
        Debug.Log("Hola");
    }

    public void Desviar()
    {
        Debug.Log("Funciona");
        GeneradorDeCubos var = FindObjectOfType<GeneradorDeCubos>();
        if (var != null)
        {
            Debug.Log("Funciona");
            int cont = var.numBolas;
            if (cont >= 4)
            {
                Debug.Log("Funciona");
                Vector3 vectorAleatorio = new Vector3(Random.Range(fuerzaMin, fuerzaMax), 0, Random.Range(fuerzaMin, fuerzaMax));
                gameObject.GetComponent<Rigidbody>().AddForce(vectorAleatorio, ForceMode.Impulse);
                Debug.Log(gameObject.GetComponent<Rigidbody>().GetAccumulatedForce());

                Collider miCollider = GameObject.Find("tapa").GetComponent<Collider>();
                if (miCollider == null)
                {
                    miCollider.enabled = true;
                }
            }
        }

        
    }
}
