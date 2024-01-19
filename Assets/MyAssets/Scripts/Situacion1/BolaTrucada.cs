using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolaTrucada : MonoBehaviour
{
    public float fuerzaMin;
    public float fuerzaMax;
    public float fuerzaIntermediaMin;
    public float fuerzaIntermediaMax;
    public Vector3 fuerza;
    public float velocidadMinimaParaDesviar;

    public void Prueba()
    {
        Debug.Log("Hola");
    }

    public void Desviar()
    {
        Debug.Log(gameObject.GetComponent<Rigidbody>().velocity.sqrMagnitude);
        //Debug.Log("Funciona");
        GeneradorDeCubos var = FindObjectOfType<GeneradorDeCubos>();
        if (var != null)
        {
            //Debug.Log("Funciona");
            int cont = var.numBolas;
            if (cont >= 4 && GetComponent<Rigidbody>().velocity.sqrMagnitude > velocidadMinimaParaDesviar)
            {
                Debug.Log("Funciona");
                Vector3 vectorAleatorio = new Vector3(Random.Range(fuerzaMin, fuerzaMax), 0, Random.Range(fuerzaMin, fuerzaMax));
                //while ((vectorAleatorio.x<fuerzaIntermediaMax && vectorAleatorio.x > fuerzaIntermediaMin) || (vectorAleatorio.y < fuerzaIntermediaMax && vectorAleatorio.y > fuerzaIntermediaMin))
                //{
                 //   vectorAleatorio = new Vector3(Random.Range(fuerzaMin, fuerzaMax), 0, Random.Range(fuerzaMin, fuerzaMax));
               // }
                gameObject.GetComponent<Rigidbody>().AddForce(vectorAleatorio, ForceMode.Impulse);
                Debug.Log(gameObject.GetComponent<Rigidbody>().GetAccumulatedForce());
               
            }
        }
        
    }
}
